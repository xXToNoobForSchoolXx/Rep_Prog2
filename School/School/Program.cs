///<summary>
/// Namn: Simon Gottfridsson
/// Klass: SY21
/// Info:
/// Programmet låter användaren att skriva in x-antal anställda som sedan vissas i programmets slut.
/// </summary>
namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            string name;
            string sSN;

            while (true)
            {
                Console.WriteLine("(L)ärare / (C)hef / (A)vsluta");
                string ans = Console.ReadLine().ToLower();

                if (ans == "a")
                {
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Namn:");
                    name = Console.ReadLine();

                    if (name != null)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Felaktig input");
                    }
                }

                while (true)
                {
                    Console.Write("Personnummer: ");
                    sSN = Console.ReadLine();

                    if (sSN != null)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Felaktig input");
                    }
                }

                if (ans == "l")
                {
                    string subjects;

                    while (true)
                    {

                        Console.WriteLine("Ämnen: ");
                        subjects = Console.ReadLine();

                        if (subjects != null)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Felaktig input");
                        }
                    }

                    employees.Add(new Teacher(name, sSN, subjects));
                }

                if (ans == "c")
                {
                    employees.Add(new Principal(name, sSN));
                }
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.getInfo(), Console.Read());
                Console.WriteLine("\nProgrammet stängs av om 10 sekunder.");
                System.Threading.Thread.Sleep(100000);
            }
        }
    }
}