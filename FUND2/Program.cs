// See https://aka.ms/new-console-template for more information
using FUND2.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



namespace FUND2 { 
    class Program
    {
        //-------------------Solicitudes a Servicios Web por HTTP GET ------

        static async Task Main(string[] args)
        //----------------------------------------------------------------BASICOS----------------------------------------------------------------
        {   //Arrreglos en c#

            //int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("****************************************");


            //listas en C#

            //List<int> list = new List<int>() {1,2,3,4,5,6,7,8};
            //list.Add(9);
            //list.Add(0);
            //list.Remove(2);

            //foreach ( var el in list)
            //{
            //    Console.WriteLine("elemento "+el);
            //}




            //List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10,"Artesanal Honey") };
            //cervezas.Add(new Cerveza(300, "Quilmes"));
            //Cerveza sneider = new Cerveza(500, "Sneider");
            //cervezas.Add(sneider);

            //foreach (var el in cervezas)
            //{
            //    Console.WriteLine("cerveza=  " + el.Nombre);
            //}

            // ------------------------------------------------------------INTERFACES EN C#-----------------------------------------------------

            //var bebidaAlcoholica = new Cerveza(100);
            //MostrarRecomendacion(bebidaAlcoholica);





            //----------------------------------------------------------- Conexion a BD en C# con MySql-------------------------------------------------------------
            //Cconexion cervezaDb = new Cconexion();
            /*{
                //insertamos Una cerveziña
                Cerveza cerveza = new Cerveza(30, "Millher");
                cerveza.Marca = "Miller";
                cerveza.Alcohol = 8;
                cervezaDb.Add(cerveza);

            }*/
            /*{
                Cerveza cerveza = new Cerveza(5, "Lachela");
                cerveza.Marca = "JEJEXD";
                cerveza.Alcohol = 10;
                cervezaDb.Edit(cerveza,7);
            }
            */
            //{
            //    cervezaDb.Delete(7);
            //}

            ////para obtener todas las cerveziñas bro
            //var cervezas = cervezaDb.GetCervezas();


            //foreach (var c in cervezas) {
            //    Console.WriteLine(c.Nombre+" "+c.Marca+" %Alcohol:"+c.Alcohol+" Stock:"+c.Cantidad+"\n");
            //}
            //----------------------------------------------------------------SERIALIZACION DE OBJETOS CON JSON ---------------------------------------



            //Cerveza cerveza = new Cerveza(10, "Deprueba");
            //cerveza.Alcohol = 3;
            //cerveza.Marca = "Quseyo";

            //string miJson = JsonSerializer.Serialize(cerveza); // esta funcion me convierte el objeto en uno del tipo JSON ;
            //Console.WriteLine(miJson);

            //File.WriteAllText("objeto.txt", miJson);


            //string mijson = File.ReadAllText("objeto.txt");

            //Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(mijson);

            //Console.WriteLine(cerveza.Nombre);


            //-------------------Solicitudes a Servicios Web por HTTP GET ----------------


            //string url = "https://jsonplaceholder.typicode.com/posts";

            //HttpClient client = new HttpClient();

            ////await me dice que no va a pasar hasta que termine;
            //var httpResponse = await client.GetAsync(url);

            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var content = await httpResponse.Content.ReadAsStringAsync();

            //    List<Models.Posts> posts = JsonSerializer.Deserialize<List<Models.Posts>>(content);
            //    Console.WriteLine(posts);
            //}


            //----------------Solicitudes a Servicios web por HTTP POST, PUT, DELETE--------------------------



            //string url = "https://jsonplaceholder.typicode.com/posts";
            //var client = new HttpClient();
            //Posts post = new Posts()
            //{
            //    userId = 50,
            //    body = "hola que tal ",
            //    title = "hola soy el titulo",
            //};

            //var data = JsonSerializer.Serialize<Posts>(post);
            //HttpContent content = new StringContent(data,System.Text.Encoding.UTF8,"application/json");

            //var httpResponse = await client.PostAsync(url, content);

            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var result = await httpResponse.Content.ReadAsStringAsync();
            //    var postResult = JsonSerializer.Deserialize<Posts>(result);
            //    Console.WriteLine(postResult.title);
            //}



            //   PUT

            //string url = "https://jsonplaceholder.typicode.com/posts/33";
            //var client = new HttpClient();
            //Posts post = new Posts()
            //{
            //    userId = 50,
            //    body = "hola que tal ",
            //    title = "hola soy el titulo",
            //};

            //var data = JsonSerializer.Serialize<Posts>(post);
            //HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            //var httpResponse = await client.PutAsync(url,content);

            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var result = await httpResponse.Content.ReadAsStringAsync();
            //    var postResult = JsonSerializer.Deserialize<Posts>(result);

            //}

            //  DELETE




            //de interfaces
            //static void MostrarRecomendacion(IBebidaAlcoholica bebida)
            //{
            //    bebida.MaximoRecomendado();
            //}
        }
    }


}
