using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_4_1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Training File\\File Nancy\\student_data.txt";
            List<Student> students = new List<Student>();

            // Read data from the text file and store it in the list
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 3)
                        {
                            string name = data[0];
                            string id = data[1];
                            string grade = data[2];
                            students.Add(new Student(name, id, grade));
                        }
                    }
                }

                // Display the student data on the console
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, ID: {student.ID}, Grade: {student.Grade}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading data from the file: {ex.Message}");
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Grade { get; set; }

        public Student(string name, string id, string grade)
        {
            Name = name;
            ID = id;
            Grade = grade;

        }
    }
}
