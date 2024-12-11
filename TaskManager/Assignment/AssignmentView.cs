namespace TaskManager.Assignment;

public class AssignmentView
{
    private  void DisplayAssignment(IAssignment assignment)
    {
        Console.WriteLine($"Title: {assignment.Title}");
        Console.WriteLine($"Due Date: {assignment.DueDate}\n");
    }
    public  void DislpayAssignments(IAssignmentController assignmentController)
    {
        
        var assignments = assignmentController.GetAssignments();
        
        foreach (var assignment in assignments)
        {
            DisplayAssignment(assignment);
        }
    }
    public  void DislpayAssignments(IAssignmentController assignmentController,string title = "N/A", int countItems = 0)
    {
        Console.WriteLine(title);
        var assignments = assignmentController.GetAssignments();
        if (countItems == 0)
        {
            Console.WriteLine("Arguments are invalid");
        }
        if(assignments.Count == 0)
        {
            Console.WriteLine("No assignments found");
        }

        for (int i = 0; i < assignments.Count(); i++)
        {
            if(i == countItems)
            {
                break;
            }
            DisplayAssignment(assignments[i]);
        }
        
        
    }
    
   
}