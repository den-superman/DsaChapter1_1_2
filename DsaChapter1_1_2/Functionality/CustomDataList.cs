using DsaChapter1_1_2.Entities;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaChapter1_1_2.Functionality
{
    public class CustomDataList
    {
        private List<Student> students = new List<Student>();
        public int Lenght;
        public Student First;
        public Student Last;


        public void AddStudent(Student student)
        {
            students.Add(student);
            Last = student;
            Lenght = students.Count;
            First = students[0];
        }

        public void RemoveByIndex(int index)
        {
            students.RemoveAt(index);
            Lenght = students.Count;
            if (Lenght > 0)
            {
                if (index == 0)
                {
                    First = students[0];
                }
                if (index == Lenght - 1)
                {
                    Last = students[Lenght - 1];
                }
            }
        }

        public Student GetElement(int index)
        {
            return students[index];
        }

        public List<Student> DisplayAll()
        {
            return students;
        }

        public void RemoveFirst()
        {
            students.RemoveAt(0);
            Lenght = students.Count;
            if (Lenght > 0)
            {
                First = students[0];
            }
            
        }

        public void RemoveLast()
        {
            students.RemoveAt(Lenght - 1);
            Lenght = students.Count;
            if (Lenght > 0)
            {
                Last = students[Lenght - 1];
            }
            
        }

        public void LoadFromFile(string file_name)
        {
            string[] lines = File.ReadAllLines(file_name);
            char[] separators = new char[] { ',', ' ', };
            foreach (var line in lines)
            {
                string[] stud = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student() { FirstName = stud[0], LastName = stud[1], AverageScore = float.Parse(stud[3], CultureInfo.InvariantCulture.NumberFormat), StudentNumber = stud[2] });
            }
            Lenght = students.Count;
            First = students[0];
            Last = students[Lenght - 1];
        }
        

        public void Sorting(string SortColumn, string SortDirection)
        {
            if (SortColumn == "First Name" && SortDirection == "Ascending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].FirstName, students[j + 1].FirstName) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "First Name" && SortDirection == "Descending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].FirstName, students[j + 1].FirstName) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Last Name" && SortDirection == "Ascending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].LastName, students[j + 1].LastName) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Last Name" && SortDirection == "Descending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].LastName, students[j + 1].LastName) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Student #" && SortDirection == "Ascending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].StudentNumber, students[j + 1].StudentNumber) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Student #" && SortDirection == "Descending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].StudentNumber, students[j + 1].StudentNumber) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Average Score" && SortDirection == "Ascending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (students[j].AverageScore > students[j + 1].AverageScore)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (SortColumn == "Average Score" && SortDirection == "Descending")
            {
                for (int i = 0; i < students.Count; ++i)
                {
                    for (int j = 0; j < students.Count - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (students[j].AverageScore < students[j + 1].AverageScore)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            First = students[0];
            Last = students[Lenght - 1];
            
        }
    }
}
