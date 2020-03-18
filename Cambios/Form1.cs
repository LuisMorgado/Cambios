namespace Cambios
{
    using Cambios.Servicos;
    using modelos;//engano.. Criar Sempre com letra maiuscula mesmo que sejam pasta
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region Atributos

        private List<Rate> Rates;
        private NetworkService networkService;
        private ApiService apiService;
        private DialogeService dialogeService;
        private DataService dataService;

        #endregion

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogeService = new DialogeService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool load;

            lbl_resultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocarRates();
                load = false;
                return;
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if (Rates.Count == 0)
            {
                lbl_resultado.Text = "Não há ligação á internet" + Environment.NewLine + "e não foram previamente carregadas as taxas." + Environment.NewLine + "Tente mais tarde";

                lbl_status.Text = "Primeira inicialização, deverá ter ligação á internet";
                return;
            }

            cb_origem.DataSource = Rates;
            cb_origem.DisplayMember = "Name";

            cb_destino.BindingContext = new BindingContext();// Classe que nos liga o interface ao codigo. neste caso temos de dizer que as combo boxes têm destinos diferentes(Serve para corrigir bug da microsoft)

            cb_destino.DataSource = Rates;
            cb_destino.DisplayMember = "Name";



            lbl_resultado.Text = "Taxas atualizadas";

            if (load)
            {
                lbl_status.Text = string.Format("Taxas carregadas da internet em {0:f}", DateTime.Now);
            }
            else
            {
                lbl_status.Text = string.Format("Taxas carregadas da dase de dados");
            }

            progressBar1.Value = 100;

            btn_converter.Enabled = true;
            btn_troca.Enabled = true;
        }

        private void LoadLocarRates()
        {
            Rates =  dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambiosrafa.azurewebsites.net", "/api/Rates");

            Rates = (List<Rate>)response.Result;

            dataService.DeleteData();

            dataService.SaveData(Rates);
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if (string.IsNullOrEmpty(txt_valor.Text))
            {
                dialogeService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;
            if (!decimal.TryParse(txt_valor.Text, out valor))
            {
                dialogeService.ShowMessage("Erro de conversão", "Valor terá de ser numérico");
                return;
            }

            if (cb_origem.SelectedItem == null)
            {
                dialogeService.ShowMessage("Erro", "Tem de escolher uma moeda a converter");
                return;
            }

            if (cb_destino.SelectedItem == null)
            {
                dialogeService.ShowMessage("Erro", "Tem de escolher uma moeda de destino para converter");
                return;
            }

            var taxaOrigem = (Rate) cb_origem.SelectedItem;
            var taxaDestino = (Rate)cb_destino.SelectedItem;

            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;

            lbl_resultado.Text = string.Format("{0} {1:c2} = {2} {3:c2}", taxaOrigem.Code, valor, taxaDestino.Code, valorConvertido);
        }

        private void btn_troca_Click(object sender, EventArgs e)
        {
            Troca();
        }

        private void Troca()
        {
            var aux = cb_origem.SelectedItem;
            cb_origem.SelectedItem = cb_destino.SelectedItem;
            cb_destino.SelectedItem = aux;
            Converter();
        }
    }
}
