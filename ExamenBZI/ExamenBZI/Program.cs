namespace ExamenBZI
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int Age
        {
            get

            {
                int currentYear = DateTime.Now.Year;
                return currentYear - YearOfBirth;
            }
        }
    }

  
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de persoane este: ");
            int numarPersoane = Convert.ToInt32(Console.ReadLine());
            Person[] persoane = new Person[numarPersoane];

            for (int i = 0; i < numarPersoane; i++)
            {
                Console.WriteLine("Person" + i + "is:");
               
                Person persoana = new Person();
                
                Console.WriteLine("First name is: ");
                
                persoana.FirstName = Console.ReadLine();
                
                Console.WriteLine("Last name is: ");
                
                persoana.LastName = Console.ReadLine();
                
                Console.WriteLine("Anul nasterii este: ");
                
                persoana.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                
                persoane[i] = persoana;

                Console.WriteLine($"Person {i + 1}: {persoane[i].FirstName} {persoane[i].LastName}, Year of Birth: {persoane[i].YearOfBirth}, Age: {persoane[i].Age}");

            }
            Console.ReadLine();
        }
    }
}