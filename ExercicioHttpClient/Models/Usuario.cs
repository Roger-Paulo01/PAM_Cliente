using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHttpClient.Models
{
    public class Usuario
    {
        /*{   "CPF": "111.111.111-09",
              "Nome": "Camila Castro"    }*/
        
        //Criamos duas propriedades iguais à resposta da API
        //Uma propriedade é um atributo com encapsulamento
        public string CPF { get; set; }
        public string Nome { get; set; }
        
        
        /*
        Exemplo de criação de propriedade
        Para criar, botão direito, Quick Actions and... e Encapsulate...
        e clicar em Encapsulate Field and use Property
        ex.:
        public string Exemplo { get => exemplo; set => exemplo = value; }
        private string exemplo;
        */
    }
}
