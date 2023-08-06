using System;

namespace St
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public void SetName(string fName, string lName)
        {
            this.SetFirstName(fName);
            this.SetLastName(lName);
        }
        public void SetFirstName(string name)
        {
            this.firstName = name;
        }
        public void SetLastName(string name)
        {
            this.lastName = name;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student st = new Student();
            st.SetName("asd", "sad");
            Console.WriteLine($"{st.lastName} {st.firstName}");
        }
    }
}
