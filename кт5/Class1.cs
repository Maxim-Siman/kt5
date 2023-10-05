using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кт5
{

    public interface IComparable<T>
    {
        public int CompareTo(T other);
    }
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public int CompareTo(Student other)
        {
            if (Name.CompareTo(other.Name) == 0)
            {
                if (Age.CompareTo(other.Age) == 0)
                {
                    return Grade.CompareTo(other.Grade);
                }
                else
                {
                    return Age.CompareTo(other.Age);
                }
            }
            else
            {
                return Name.CompareTo(other.Name);
            }
        }
    }

    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public int CompareTo(Book other)
        {
            if (Title.CompareTo(other.Title) == 0)
            {
                if (Author.CompareTo(other.Author) == 0)
                {
                    return Price.CompareTo(other.Price);
                }
                else
                {
                    return Author.CompareTo(other.Author);
                }
            }
            else
            {
                return Title.CompareTo(other.Title);
            }
        }
    }
}
