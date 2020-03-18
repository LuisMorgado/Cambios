namespace Cambios.Servicos
{
    using System.Windows.Forms;

    public class DialogeService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
    }
}
