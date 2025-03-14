namespace HelloWorld.Exercise{
    public class LinqWithObjectsExamples{
        public static void linqWithObjectsExamples(){
            List<Person> people = new List<Person>()
            {
                new Person("Tod", 180, 70, Gender.Male),
                new Person("John", 170, 88, Gender.Male),
                new Person("Anna", 150, 48, Gender.Female),
                new Person("Kyle", 164, 77, Gender.Male),
                new Person("Anna", 164, 77, Gender.Male),
                new Person("Maria", 160, 55, Gender.Female),
                new Person("John", 160, 55, Gender.Female)
            };

            // var fourCharName = from p in people where p.Name.Length == 4 select p;
            // var fourCharNamesOrdered = from name in fourCharName orderby name.Name select name ;
            // var extractingNames = from name in fourCharNamesOrdered select name.Name;
            // var multipleOrders = from name in fourCharNamesOrdered orderby name.Height,name.Weight select name ;

            // Console.WriteLine(string.Join(",",fourCharName));
            // Console.WriteLine("");
            // Console.WriteLine(string.Join(",",fourCharNamesOrdered));
            // Console.WriteLine("");
            // Console.WriteLine(string.Join(",",extractingNames));
            // Console.WriteLine("");
            // Console.WriteLine(string.Join(",",multipleOrders));

            var groupedByWeight = from p in people group p by p.Weight ;

            foreach(var key in groupedByWeight){
                Console.WriteLine(key.Key);
                foreach(var value in key){
                    Console.WriteLine(key.Key + " " + value);
                }
            }

        }
    }

    internal class Person{
        
        private string name;
        private int height;
        private int weight;

        private Gender gender;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public Person(string name, int height, int weight, Gender gender)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Gender = gender;
        }
    }

    internal enum Gender
    {
        Male,
        Female
    }
}