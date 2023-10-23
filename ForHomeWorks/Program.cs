namespace ForHomeWorks
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var result = Student1.GetAllTeachers().GroupJoin(Student1.GetAllStudents(), 
                student => student.TalimShakli,
                teacher => teacher.TalimShakli, 
                (teacher, student) => new
                {
                    teacherName = teacher.FirstName,
                    student = student

                }).ToList();

            foreach (var i in result)
            {
                Console.WriteLine(i.teacherName);
                Console.Write("Uquvchilari: ");
                foreach (var j in i.student)
                {
                    Console.Write(j.FirstName + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Student1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Credite { get; set; }
        public decimal Contract { get; set; }
        public string UniversityBranch { get; set; }
        public string UniversityName { get; set; }
        public string UniversityFaculty { get; set; }
        public int Course { get; set; }
        public string TalimShakli { get; set; }


        public static List<Student1> GetAllStudents()
        {
            List<Student1> students = new List<Student1>()
        {
            new Student1 { Id = 1, FirstName = "Rustambek", LastName = "Jurayev", Age = 23, Credite = 8,
                Contract = 9_000_000, UniversityBranch = "Toshkent", UniversityName = "Irrigatsiya",
                UniversityFaculty = "Qishloq xo'jaligi", Course = 1 , TalimShakli = "Kunduzgi"},

            new Student1 { Id = 2, FirstName = "Nurmuhammad", LastName = "SHarobiddinov", Age = 20, Credite = 8,
                Contract = 9_000_000, UniversityBranch = "Anjan", UniversityName = "ADU",
                UniversityFaculty = "Komputer Science", Course = 3 , TalimShakli = "Kechgi"},

            new Student1 { Id = 3, FirstName = "Hushnud", LastName = "Kamolov", Age = 33, Credite = 21,
                Contract = 10_200_000, UniversityBranch = "Samarqand", UniversityName = "SAMDU",
                UniversityFaculty = "Fizika", Course = 2 , TalimShakli = "Kunduzgi"},

            new Student1 { Id = 4, FirstName = "Mirqosim", LastName = "Uzoqov", Age = 28, Credite = 40,
                Contract = 7_000_100, UniversityBranch = "Buhoro", UniversityName = "INHA",
                UniversityFaculty = "Logistika", Course = 4 , TalimShakli = "Kechgi"},

            new Student1 { Id = 4, FirstName = "Abdusalom", LastName = "Abdusalomov", Age = 28, Credite = 40,
                Contract = 7_000_100, UniversityBranch = "Buhoro", UniversityName = "INHA",
                UniversityFaculty = "Logistika", Course = 4 , TalimShakli = "Kechgi"},

            new Student1 { Id = 4, FirstName = "Bahriddin", LastName = "Axunov", Age = 28, Credite = 40,
                Contract = 7_000_100, UniversityBranch = "Buhoro", UniversityName = "INHA",
                UniversityFaculty = "Logistika", Course = 4 , TalimShakli = "Kechgi"},

            new Student1 { Id = 5, FirstName = "Jonpo'lat", LastName = "Jurayev", Age = 23, Credite = 10,
                Contract = 9_000_000, UniversityBranch = "Namangan", UniversityName = "Madrasa",
                UniversityFaculty = "Tafseer", Course = 1 , TalimShakli = "Kechgi"},

            new Student1 { Id = 6, FirstName = "Sevinch", LastName = "Xayriddinova", Age = 31, Credite = 15,
                Contract = 15_300_700, UniversityBranch = "Qashqadaryo", UniversityName = "TATU",
                UniversityFaculty = "Komputer Injiniringi", Course = 3 , TalimShakli = "Kunduzgi"},

            new Student1 { Id = 7, FirstName = "Farxodbek", LastName = "Madrahimov", Age = 27, Credite = 32,
                Contract = 4_000_000, UniversityBranch = "Horazim", UniversityName = "Urganch University",
                UniversityFaculty = "Matematika", Course = 4 , TalimShakli = "Kechgi"},

            new Student1 { Id = 8, FirstName = "Farxodbek", LastName = "Rustamov", Age = 19, Credite = 57,
                Contract = 13_000_000, UniversityBranch = "Farg'ona", UniversityName = "KIUF",
                UniversityFaculty = "Kareys tili", Course = 2 , TalimShakli = "Kunduzgi"},
        };

            return students;
        }


        public static List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher { Id = 1, FirstName = "Asror", Age = 27, Spetiality = "Dasturlash", TechCourse = 1 ,TalimShakli = "Kunduzgi"},
                new Teacher { Id = 2, FirstName = "Muhammad Abdulloh", Age = 23, Spetiality = "DotNet", TechCourse = 2 ,TalimShakli = "Kechgi"},
                new Teacher { Id = 3, FirstName = "Rustambek", Age = 15, Spetiality = "Backend", TechCourse = 4 ,TalimShakli = "Kunduzgi"},
                new Teacher { Id = 4, FirstName = "Nodir", Age = 29, Spetiality = "Frontend", TechCourse = 3 ,TalimShakli = "Kechgi"}
            };

            return teachers;

        }

    }

    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Spetiality { get; set; }
        public int TechCourse { get; set; }
        public string TalimShakli { get; set; }
    }
}