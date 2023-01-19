// See https://aka.ms/new-console-template for more information

namespace AnnaApp
{
    class MainApp {
        static void Main(String[] args) {
            Console.WriteLine("Hello, World!");
            
            Person person = new Person("Anna", 17);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            person.RenamePerson("Gavin");
            Console.WriteLine(person.Name);
        }
    }
}


