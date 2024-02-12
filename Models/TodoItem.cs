namespace BlazorApp.Models;
public class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; } = false;
    public int Order { get; set; }
}