namespace HouseManager.API.Services;

public class Responsabilities
{
    public Responsabilities(List<Task> toDoList)
    {
        ToDoList = toDoList;
    }

    public List<Task> ToDoList { get; set; }
}