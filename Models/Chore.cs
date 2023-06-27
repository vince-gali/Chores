
// using System.ComponentModel.DataAnnotations;
namespace Chores.Models;

public class Chore{
    public Chore(int id, string name, string description, bool? completed)
    {
        Id = id;
        Name = name;
        Description = description;
        Completed = completed;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    //TODO - add bool to allow chore to be completed
    public bool? Completed { get; set; }
    
}