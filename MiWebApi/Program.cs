using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using EspacioClase;

HttpClient client = new HttpClient();
string url = "https://dog.ceo/api/breeds/image/random";

HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();

string body = await response.Content.ReadAsStringAsync();
Console.WriteLine(body);
Perro perro = JsonSerializer.Deserialize<Perro>(body);

Console.WriteLine("----Generador de Links Para Ver Fotos Random de Perros----");
Console.WriteLine("Aqui esta tu link: "+perro.Message);

string json = JsonSerializer.Serialize(perro);
string ruta = Directory.GetCurrentDirectory() + @"\perro.json";
File.WriteAllText(ruta,json);