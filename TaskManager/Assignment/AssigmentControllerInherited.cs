namespace TaskManager.Assignment;

public class AssigmentControllerInherited : AssignmentController
{
   public override void AddAssignment(IAssignment assignment)
   {
       Console.WriteLine("Start inheritance");
       base.AddAssignment(assignment);
       Console.WriteLine("Stop inheritance");
   }
   public override List<Assignment> GetAssignments()
   {
       Console.WriteLine("Start inheritance");
       var assignments = base.GetAssignments();
       Console.WriteLine("Stop inheritance");
       return assignments;
   }
}