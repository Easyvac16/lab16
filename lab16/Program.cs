namespace lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What task you want to start: 1 - Numbers, 2 - City's, 3 - Student's, 0 - Exit");
            int a = int.Parse(Console.ReadLine());
            
            
                switch (a)
                {
                    case 1:
                        cs1.task_1();
                        break;
                    case 2:
                        cs2.task_2();
                        break;
                    case 3:
                        cs3.task_3();
                        break;
                }
            
                

            
        }
    }
}