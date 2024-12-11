using TaskManager.Assignment;

namespace TaskManager;


class Program
{
  
    static void Main(string[] args)
    {
        // Напишіть ще директивами препроцесора 2 виводи повідомлення з версією .NET. Одне повідомлення маю спрацювати для вашої версії, інше має не спрацювати, бо версія не підходить зараз під вашу, але може спрацювати, якщо скомпілювати з якоюсь іншою версією .NET ваш код.
        #if NET8_0_OR_GREATER
        AssignmentView assignmentView = new AssignmentView();
        AssignmentController assignmentController = new AssignmentController();
        AssigmentControllerInherited assignmentControllerInherited = new AssigmentControllerInherited();
        IAssignment assignmentFirst = new Assignment.Assignment("First Assignment", DateTime.Now.AddDays(7));
        IAssignment assignmentSecond = new Assignment.Assignment("Second Assignment", DateTime.Now.AddDays(3));
        assignmentController.AddAssignment(assignmentFirst);
        assignmentController.AddAssignment(assignmentSecond);
        
        // Вивести всі завдання.
        assignmentView.DislpayAssignments(assignmentController);
        
        //Також напишіть дочірній клас сервісу, що буде викликати методи базового класу, а перед ними і після них буде виводити в консоль повідомлення про початок і кінець виклику цього методу. Методи дочірнього класу мають запускатись навіть якщо привести тип до батьківського типу.
        assignmentView.DislpayAssignments((AssignmentController)assignmentControllerInherited);
        // Метод сервісу, що виводить завдання, повинен приймати змінну кількість цих завдань і тоді виводити, а також текстовий заголовок, що буде виводитись перед тим. Якщо заголовок не передали, то має виводитись заголовок "N/A", 
        assignmentView.DislpayAssignments(assignmentController, title:"WOWOWOW",countItems:1);
        #else
        Console.WriteLine("This program requires .NET 8.0 or later to run.");
#endif
        
    }
}