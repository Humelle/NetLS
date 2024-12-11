using System.Text.Json;

namespace TaskManager.Assignment;

public class AssignmentController : IAssignmentController
{
    // Додати завдання до списку.
    // Зберегти завдання в JSON-файл.
    public virtual void AddAssignment(IAssignment assignment)
    {
        List<Assignment> assignments = GetAssignments();
        assignments.Add((Assignment)assignment);
        string json = JsonSerializer.Serialize(assignments);
        if (!File.Exists("assignments.json"))
            File.Create("assignments.json");
        File.WriteAllText("assignments.json", json);
    }
// Завантажити завдання з JSON-файлу.
    public virtual List<Assignment> GetAssignments()
    {
        if (!File.Exists("assignments.json"))
            File.Create("assignments.json");
        string json = File.ReadAllText("assignments.json");
        if (string.IsNullOrEmpty(json))
            return new List<Assignment>();
        return JsonSerializer.Deserialize<List<Assignment>>(json) ?? new List<Assignment>();
    }
}