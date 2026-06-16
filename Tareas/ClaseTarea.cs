using System.Text.Json.Serialization;

namespace EspacioTarea;

public class Tarea{
    private int userId;
    private int id;
    private string title;
    private bool completed;
    [JsonPropertyName("userId")]
    public int UserId { get => userId; set => userId = value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("title")]
    public string Title { get => title; set => title = value; }
    [JsonPropertyName("completed")]
    public bool Completed { get => completed; set => completed = value; }

    public Tarea(int a, int b, string c, bool d){
        this.userId = a;
        this.id = b;
        this.title = c;
        this.completed = d;
    }
    public Tarea(){

    }
}
