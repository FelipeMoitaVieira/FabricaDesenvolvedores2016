using Fiap.Exemplo03.UI.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo03.UI.Console.Repositories
{
    public class Repository
    {
        public IEnumerable<AlunoDTO> AlunoGet()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63190/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/aluno").Result;
                IEnumerable<AlunoDTO> listaAluno = null;
                if (response.IsSuccessStatusCode)
                {
                   listaAluno  = response.Content.ReadAsAsync<IEnumerable<AlunoDTO>>().Result;
                }
                return listaAluno;
            }
        }


        public void AlunoPost(AlunoDTO aluno)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63190/");
                
                HttpResponseMessage response = client.PostAsJsonAsync("api/aluno", aluno).Result;
                if (response.IsSuccessStatusCode)
                {
                    Uri uri = response.Headers.Location;
                }
            }
        }





    }
}
