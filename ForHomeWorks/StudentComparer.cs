using System.Diagnostics.CodeAnalysis;

namespace ForHomeWorks
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            throw new NotImplementedException();
        }
    }
}