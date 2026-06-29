using System.Net.Http;
using System;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json;
using EspacioUsuario;

String url = "https://jsonplaceholder.typicode.com/users/";
HttpClient client = new HttpClient();

HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();

string body = await response.Content.ReadAsStringAsync();
List<Usuario>? listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(body);

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Nombre: "+listaUsuarios[i].Name);
    Console.WriteLine("Email: "+listaUsuarios[i].Email);
    Console.WriteLine("Domicilio: "+listaUsuarios[i].Address.Street);
    Console.WriteLine("----------------------------------------");

}

string json = JsonSerializer.Serialize(listaUsuarios);
string ruta = Directory.GetCurrentDirectory()+@"\usuarios.json";

Console.WriteLine(ruta);

File.WriteAllText(ruta,json);
