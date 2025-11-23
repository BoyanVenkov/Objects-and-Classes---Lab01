class Program
{
    class Student
    {
        public Student(string firstName, string lastNamr, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastNamr;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        List<Student> students = new List<Student>();

        while (input[0] != "end")
        {
            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            string homeTown = input[3];

            Student currentStudent = new Student(firstName, lastName, age, homeTown);
            if (students.Any(s => s.FirstName == firstName && s.LastName == lastName))
            {
                students.First(s => s.FirstName == firstName && s.LastName == lastName).Age = age;
                students.First(s => s.FirstName == firstName && s.LastName == lastName).HomeTown = homeTown;
            }
            else
            {
                students.Add(new Student(firstName, lastName, age, homeTown));
            }
                input = Console.ReadLine().Split().ToArray();
        }
        string targetTown = Console.ReadLine();

        foreach (var student in students.Where(s => s.HomeTown == targetTown))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }


    }

}