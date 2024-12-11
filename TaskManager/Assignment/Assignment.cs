namespace TaskManager.Assignment;

public class Assignment : IAssignment
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    
    public Assignment(string title, DateTime dueDate)
    {
        Title = title;
        DueDate = dueDate;
    }

   
}