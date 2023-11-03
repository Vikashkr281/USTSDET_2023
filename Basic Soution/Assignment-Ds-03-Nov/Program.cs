// See https://aka.ms/new-console-template for more information
using Assignment_Ds_03_Nov;

TaskTtem taskTtem1 = new TaskTtem();

Console.WriteLine("____________________________________Welcome to Linear DS_________________________");
int x = 1;
while(x==1)
{
    Console.WriteLine("Enter the operation U Want to perform");
    Console.WriteLine("1 for ADD \n2 for Remove \n3 for Mark task as completed\n 4 for Display");
    Console.WriteLine("Enter the correct option ");
   int option= Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            TaskTtem taskTtem = new TaskTtem();
            Console.WriteLine("For adding the details enter the required details ");
            Console.WriteLine("Enter the id ");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Task Description");
            string str=Console.ReadLine();
            Console.WriteLine("Enter the status of task");
            bool c=Convert.ToBoolean(Console.ReadLine());

            taskTtem.AddDetails(taskTtem);
            break;
         case 2:
            Console.WriteLine("If u want to remove any task the enter the task id");
            int N = Convert.ToInt32(Console.ReadLine());
            taskTtem1.RemoveTask(N);
            break; 
        case 3:
            Console.WriteLine("If u want to change the task status the press id ");
            Console.WriteLine("If u want to remove any task the enter the task id");
            int S = Convert.ToInt32(Console.ReadLine());
            taskTtem1.ChangeStatus(S);
            break;
            case 4:
            taskTtem1.Display();
            break;

            Console.WriteLine("Do u wish to continue press 1 other wise 0");
            x = Convert.ToInt32(Console.ReadLine());

    }
}
