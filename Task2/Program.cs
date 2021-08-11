using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Task2
{
    /* Задача No2 Создать класс с двумя переменными. Добавить конструктор с входными параметрами.
     * Добавить конструктор, инициализирующий члены класса по умолчанию. Добавить деструктор, выводящий на экран
     * сообщение об удалении объекта.
     */
    
    public class Employee
    {
        public int age;
        public string name;
        
        public Employee()
        {
            Console.WriteLine("By default");
        }
        
        public Employee(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        ~Employee()
        {
            Console.WriteLine("Disposed");
        }

        public static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            Employee employeeTwo = new Employee(27, "Viktoryia Latosh");
        }
    }
}