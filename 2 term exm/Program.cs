using System.ComponentModel.Design;

class Program
{
    private static readonly IEnumerable<string> waitingQueue;

    private static void printItems(Queue<string> items)
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        static void Main()
        {
            Queue<string> students = new Queue<string>();
            int studentswaiting = 0;
            int code;

            Console.WriteLine("*=====*======*======*=======*====");
            Console.WriteLine(" STUDENT QUEUE MANAGEMENT SYSTEM");
            Console.WriteLine("====*======*=======*======*======");

            int choice;

            do

            {
             
                Console.WriteLine("[1] Add Student");
                Console.WriteLine("[2] Show Waiting Student");
                Console.WriteLine("[3] Serve Next Student");
                Console.WriteLine("[4] Show Last Student");
                Console.Write("[5] Exit");

                Console.Write("\nEnter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Add Student");
                        string name = Console.ReadLine();
                        students.Enqueue(name);
                        Console.WriteLine("New Student Has Been Added");
                        break;

                    case 2:
                        if (students.Count == 0)
                        {
                            students.Dequeue();
                            studentswaiting++;

                            Console.WriteLine("no student waiting in Queue");

                        }
                        else
                        {
                            Console.WriteLine("student curently waiting: ");
                            int i = 1;
                            foreach (string student in waitingQueue) ;
                            Console.WriteLine("$ {i}. {student}");
                            i++;
                        }
                        break;



                    case 3:
                        Console.WriteLine("\n serving student");
                        string studentserve = Console.ReadLine();
                        if (students.Contains(studentserve)) ;
                        Console.WriteLine("Student succesfully served.");

else
                            Console.WriteLine("Student is not found.");


                        break;


                    case 4:

                        if (students.Count > 0)
                            Console.WriteLine($"\n last served student: {students.Peek()}");
                        else
                            Console.WriteLine("Student is not in the list.");


                        break;
                    case 5:

                        Console.WriteLine("\n THANK YOU FOR USING THIS PROGGRAMMMMMMMM");
                        break;


                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            }
    }
}
            
    


    
