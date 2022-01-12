namespace HouseManager.API.Services;

public class Task
{
    public Task(string título, string tipo)
    {
        Título = título;
        Tipo = tipo;
    }

    public string Título { get; set; }
    public string Tipo { get; set; }
}