

namespace Cambios.Servicos
{
    using modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiService
    {
        public async Task<Response> GetRates(string urlBase, string controller)
        {
            try
            {
                //Criação do http para criar uma ligação externa
                var client = new HttpClient();
                //Endereço base da API
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                //Carregar os resultados em fomate do string para dentro da variavel 'result'
                var result = await response.Content.ReadAsStringAsync();

                //Se algo correr mal...
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,

                    };
                }
                var rates = JsonConvert.DeserializeObject<List<Rate>>(result); //Converter Json numa lista de dados do tipo rate

                return new Response
                {
                    IsSuccess = true,
                    Result = rates,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
