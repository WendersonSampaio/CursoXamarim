using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using App1_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App1_ConsultarCEP.Servico
{
    public class ViaCEP_Servico
    {
        private static string Endereco_URL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscaEndereco(string cep)
        {
            string novoEnderecoURL = string.Format(Endereco_URL, cep);

            WebClient wc = new WebClient();

            string conteudo = wc.DownloadString(novoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
                                 
        }

    }
}
