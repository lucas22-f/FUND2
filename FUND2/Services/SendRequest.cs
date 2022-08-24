using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using FUND2.Models;

namespace FUND2.Services
{ 
    public class SendRequest<T>  where T : Irrequestable
        
        // GENERICS <T> indica que va a recibir una clase que le va a definir el objeto con el
        //que va a trabajar
        //vamos a enviar objetos sin importar el tipo que sea por una solicitud http post 
        
    {
        private HttpClient cl = new HttpClient();
        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var data = JsonSerializer.Serialize<T>(model);
            HttpContent content = new StringContent(data,System.Text.Encoding.UTF8,"application/json");
            var httpResponse = await cl.PostAsync(url,content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                var postResult = JsonSerializer.Deserialize<T>(result);
                Console.WriteLine(httpResponse);
                return postResult;
             }

            return default(T);
        }

    }
}
