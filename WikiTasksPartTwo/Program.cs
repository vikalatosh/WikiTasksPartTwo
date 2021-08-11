using System;

namespace WikiTasksPartTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Латош", "В.", "QA10", new[] {1, 1, 1, 1, 1});
            students[1] = new Student("Холова", "К.", "QA1", new[] {3, 3, 3, 3, 3}); 
            students[2] = new Student("Заяц", "С.", "QA8", new[] {2, 2, 2, 2, 2});
            students[3] = new Student("Рак", "Д.", "QA5", new[] {5, 5, 5, 4, 5});
            students[4] = new Student("Иванов", "И.", "QA2", new[] {0, 0, 0, 0, 0});
            foreach (Student s in students)
            {
                s.DisplayInfo();
            }
            
            Console.WriteLine("Сортировка студентов по возрастанию среднего балла");
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    Student temp = new Student();
                    if (students[i].AverageAssessment(students[i]) > students[j].AverageAssessment(students[j]))
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            foreach (Student s in students)
            {
                s.DisplayInfo();
            }
            
            Console.WriteLine("Вывод фамилий и номеров групп отличников, имеющих отметки, равные только 4 и 5");
            foreach (Student s in students)
            {
                bool isHonorStudent = true;
                foreach (int a in s.assessment)
                {
                    if (a != 4 && a != 5)
                    {
                        isHonorStudent = false;
                    }
                }
                if (isHonorStudent == true)
                {
                    Console.WriteLine($"{s.lastName} {s.groupNumber}");
                }
            }
        }
       
        public struct Student
        {
            public string lastName;
            public string name;
            public string groupNumber;
            public int[] assessment;

            public Student(string lastName, string name, string groupNumber, int[] assessment)
            {
                this.lastName = lastName;
                this.name = name;
                this.groupNumber = groupNumber;
                this.assessment = assessment;
            }

            public void DisplayInfo()
            {
                Console.Write($"{lastName} {name} {groupNumber} [");
                foreach (int a in assessment)
                {
                    Console.Write($"{a};");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
            
            public double AverageAssessment(Student student)
            {
                double sum = 0;
                double average;
                for (int i = 0; i < student.assessment.Length; i++)
                {
                    sum += student.assessment[i];
                }
                average = sum / 5;
                return average;
            }
        }
    }
}