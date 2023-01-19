namespace AnnaApp
{
    class Person {
        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        public void RenamePerson(string newName)
        {
            this.name = newName;
        }

        public string Name 
        {
            get
            { 
                return this.name;
            }
        }

        public int Age 
        {
            get; set;
        }

        protected string name;


    }
}