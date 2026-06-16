using EspacioTarea;
using System.Runtime.CompilerServices;
using System.Text.Json;

HttpClient client = new HttpClient();
string url = "https://jsonplaceholder.typicode.com/todos/";

HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();

string body = await response.Content.ReadAsStringAsync();
List<Tarea>? listaDeTareas = JsonSerializer.Deserialize<List<Tarea>>(body);

//mostrar la lista

foreach(Tarea item in listaDeTareas){
    if(item.Completed == true){
        Console.WriteLine("Titulo: "+item.Title);
        Console.WriteLine("Estado: Completada");
    }
}

Console.WriteLine("--------------------------------------------");

foreach(Tarea item in listaDeTareas){
    if(item.Completed == false){
        Console.WriteLine("Titulo: "+item.Title);
        Console.WriteLine("Estado: Pendiente");
    }
}


//pasar la lista a json
string json = JsonSerializer.Serialize(listaDeTareas);
Console.WriteLine(json);


