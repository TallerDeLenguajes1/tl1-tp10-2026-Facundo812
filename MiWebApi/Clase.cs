using System.Text.Json.Serialization;

namespace EspacioClase;
public class Perro
{
    [JsonPropertyName("message")]
    public string Message{get;set;}
    [JsonPropertyName("status")]
    public string Status{get;set;}
}