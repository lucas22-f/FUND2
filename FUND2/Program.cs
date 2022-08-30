// See https://aka.ms/new-console-template for more information
using FUND2.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Linq;
using FUND2.Errors;



namespace FUND2 {


     static class Program
    {

        public class Beer
        {
            public string Name { get; set; }
            public int Alcohol { get; set; }
        }



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

            //GET
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

            //POST

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

            //  DELETE en este caso hacemos todas las lineas correspondientes sin mandar un objeto al endpoint ya que termina con el mismo;
            //string url = "https://jsonplaceholder.typicode.com/posts/22";
            //var client = new HttpClient();
            //var httpResponse = await client.DeleteAsync(url);
            //var result = await httpResponse.Content.ReadAsStringAsync();
            //var resDelete = httpResponse.StatusCode;
            //Console.WriteLine(resDelete);


            //---------GENERICS-------------
            //le decimos generics para indicar a la clase con que tipo de objeto trabajar-


            //var cerveza = new Cerveza(500, "xd2") { Alcohol = 5, Marca = "xd"};
            //Services.SendRequest<Cerveza> ser = new Services.SendRequest<Cerveza>();
            //var rta = await ser.Send(cerveza);
            //Console.WriteLine(rta.id);

            //var miPost = new Posts() { body = "Hola", title = "quetal", userId = 50 };

            //Services.SendRequest<Posts> servicio2 = new Services.SendRequest<Posts>();
            //var rta2 = await servicio2.Send(miPost);
            //Console.WriteLine(rta2.userId+rta2.title+rta2.body);


            //------ LINQ lo utilizamos para realizar consultas a colecciones!  ya sea de la base de datos o de archivos xml arreglos listas etc

            //List<int> numeros = new List<int>() { 67,1, 2, 3, 4, 5, 6, 7, 8 };

            //var n = numeros.Where(x => x == 10).FirstOrDefault();
            //Console.WriteLine(n);

            //var orderN = numeros.OrderBy(x => x);
            //var total = numeros.Average(x => x);
            //foreach (var numer in orderN)
            //{
            //    Console.WriteLine(numer);
            //}

            //Console.WriteLine(total);



            //-------------PRACTICA CON LINQ---------------------------------
            //var cervezasOrdenadas = from d in cervezas
            //                        where d.Nombre == "Raul"
            //                        orderby d.Nombre 
            //                        select d;

            //foreach(var cerveza in cervezasOrdenadas)
            //{
            //    Console.WriteLine(cerveza.Nombre+" , "+cerveza.Marca);
            //}
            //---------------------------------------------------------------

            //List<Bar> bares = new List<Bar>()
            //{
            //    new Bar("Maddle")
            //    {
            //        ListaCerveza = new List<Cerveza>()
            //        {
            //            new Cerveza(20,"Carlos"){Alcohol=2,Marca="alejandro"},
            //            new Cerveza(2,"Raul"){Alcohol=5,Marca="zac"},
            //            new Cerveza(34,"Erne"){Alcohol=16,Marca="bravo"},
            //        }
            //    },

            //    new Bar("Lucas")
            //    {
            //        ListaCerveza=new List<Cerveza>()
            //        {

            //            new Cerveza(13,"De otra marca"){Alcohol=5,Marca="dea"},
            //            new Cerveza(349,"La mejor"){Alcohol=2,Marca="Deuna"},
            //        }
            //    },

            //    new Bar("Elvacio")

            //};

            //var bar = (from d in bares
            //          where d.ListaCerveza.Where(c => c.Nombre == "La mejor").Count() > 0
            //          select new BarData(d.Nombre)
            //          { 

            //              bebidas = (

            //              from c in d.ListaCerveza
            //              select new Bebida(c.Nombre,c.Cantidad)

            //              ).ToList()
            //           }

            //          ).ToList();

            //foreach (var a in bar)
            //{
            //    Console.WriteLine(a.Nombre);
            //}



            //List < Cerveza > cervezas = new List<Cerveza>()
            //{
            //    new Cerveza(20,"Carlos"){Alcohol=2,Marca="alejandro"},
            //    new Cerveza(2,"Raul"){Alcohol=5,Marca="zac"},
            //    new Cerveza(34,"Erne"){Alcohol=16,Marca="bravo"},
            //    new Cerveza(13,"Ariel"){Alcohol=34,Marca="delta"},

            //};

            //--------------------------------EXEPCIONES--------------------------------


            //try
            //{
            //   var searcherBeer = new Services.SearcherBeer();
            //    var cantidad = searcherBeer.GetCantidad("saadasd");
            //    Console.WriteLine("OK");


            //}
            //catch (NotFoundBeerException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("esto siempre se ejecuta");
            //}


            //---------------------------------Delegados---------------------------------

            //es un tipo que va a almacenar una firma
            //una funcion que reciba otra funcion interna que se ejecute
            //cuando queramos.

            //    Action<string, string> mostrar = (a,b)=>Console.WriteLine(a+b);
            //    HacerAlgo(mostrar);

            //    //de interfaces
            //    //static void MostrarRecomendacion(IBebidaAlcoholica bebida)
            //    //{
            //    //    bebida.MaximoRecomendado();
            //    //}
            //}
            //public static void HacerAlgo(Action<string,string> funcionFinal)
            //{
            //    Console.WriteLine("hago algo");
            //    funcionFinal("se envio desde otra funcion ","otra");
            //    Console.WriteLine("Hago algo mas");
            //}

            //public static void Show(string cad,string cad2)
            //{
            //    Console.WriteLine(cad+cad2);
            //}
            //public static int Show(string cad)
            //{
            //    return cad.Count();
            //}


            //---------------PREDICATE------------------
            //implementacion de los delegados se parece!;
            //ahorras estar desarrollando diferentes tipos
            //hace una sentencia que devuelve true o false;


            //var numbers = new List<int>{ 1,2,3,4,5,6,7,8,9,10};

            //var predicate = new Predicate<int>(x=> x%2==0);
            //Predicate<int> negative = x => !predicate(x);

            //var dividers2 = numbers.FindAll(negative);

            //dividers2.ForEach(d => { Console.WriteLine(d); });

            //var beers = new List<Beer>()
            //{
            //    new Beer(){Name ="Ipa", Alcohol = 8},
            //    new Beer(){Name ="Pale Ale",Alcohol = 5},
            //    new Beer(){Name = "Stout",Alcohol=23},
            //    new Beer() {Name ="Tripel",Alcohol = 34},
            //};


            //beers.ShowBeerThatIGetDrunk(x => x.Alcohol >= 8);


            


        }

       //public static bool IsDivider2(int x) => x % 2 == 0;
       //static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
       // {
       //     var evilBeers = beers.FindAll(condition);
       //     evilBeers.ForEach(d => { Console.WriteLine(d.Name); });
       // }
    }
}
