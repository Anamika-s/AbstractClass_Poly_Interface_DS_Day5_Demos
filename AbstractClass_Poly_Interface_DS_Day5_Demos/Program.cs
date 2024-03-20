namespace AbstractClass_Poly_Interface_DS_Day5_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Student student = new Student();
           //student.Rn = 1;
           //Console.WriteLine(student.Rn);

            //Student student = new Student();
            //Student st1 = new Student(1, "Ajay");

            // Object Initailzer
            Student student = new Student() { Rn = 1, Name = "Deepak", Batch = "DotNet", Marks = 90 };
            Student student1 = new Student() { Rn = 2, Name = "Ajay", Batch = "DotNet", Marks = 90 };
            Console.WriteLine(student1.Name);
           
            // List Initializer
            
            List<Student> students = new List<Student>()
            { 
            new Student() {Rn=1, Name="Deepak", Batch="DotNet", Marks=90},
            new Student() {Rn=2,Name = "Farhan", Batch="Java", Marks=89},
            new Student() {Rn=3,Name = "Gagan", Batch="B001", Marks=67}
            };

            int flag = 1;
            Console.WriteLine("Enter Name to Search");
            string name = Console.ReadLine();
            foreach(Student obj in students)
            {
                if(obj.Name.Equals(name))
                {
                    flag = 0;
                    break;
                }

            }
            if (flag == 1) { Console.WriteLine("rec not found"); }
            else { Console.WriteLine("rec found"); }
        }
    }
}