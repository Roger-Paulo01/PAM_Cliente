using ExercicioHttpClient.Models;
using System.Text.Json;

namespace ExercicioHttpClient
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async private void BuscarBtn_Clicked(object sender, EventArgs e)
        {
            //Pedir uma informação para a API
            //Pegar o dado, que veio da API
            //Formatar o dado para que ele seja um objeto
            //Exibir o dado na tela
            Usuario meuUsuario = new Usuario();
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://has.azure-api.net/teste");
            if (responseMessage.IsSuccessStatusCode)
            {
                //É necessário Serializar e Desserializar a informação
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                meuUsuario = JsonSerializer.Deserialize<Usuario>(conteudo, jsonSerializerOptions);
                CPFLbl.Text = meuUsuario.CPF;
                NomeLbl.Text = meuUsuario.Nome;
            }


        }
    }

}
