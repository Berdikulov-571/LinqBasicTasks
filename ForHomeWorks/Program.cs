namespace ForHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1,Name = "Bob"},
                new Student() {Id = 2,Name = "Eshmat"},
                new Student() {Id = 3,Name = "Toshmat"},
                new Student() {Id = 4,Name = "Lochin"},
                new Student() {Id = 5,Name = "Toshmat"},
                new Student() {Id = 6,Name = "Toshtemir"},
                new Student() {Id = 7,Name = "G'ishmat"},
                new Student() {Id = 8,Name = "Yalqov"}
            };

            List<Student> students2 = new List<Student>()
            {
                new Student() {Id = 1,Name = "Bob"},
                new Student() {Id = 2,Name = "Eshmat"},
                new Student() {Id = 3,Name = "Toshmat"},
                new Student() {Id = 4,Name = "Lochin"},
                new Student() {Id = 5,Name = "Toshmat"},
                new Student() {Id = 6,Name = "Toshtemir"},
                new Student() {Id = 7,Name = "G'ishmat"},
                new Student() {Id = 8,Name = "Yalqov"}
            };

            var result = students.Except(students2,new StudentComparer()).ToList();

            foreach (var i in result)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}