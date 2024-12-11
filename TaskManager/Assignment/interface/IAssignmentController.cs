namespace TaskManager.Assignment;

public interface IAssignmentController
{
    void AddAssignment(IAssignment assignment);
    List<Assignment> GetAssignments();
}