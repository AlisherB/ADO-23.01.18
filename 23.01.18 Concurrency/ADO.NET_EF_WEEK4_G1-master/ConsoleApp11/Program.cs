using ClassLibrary.Classes;
using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Program
    {
        static int consoleLeftPad = 10;
        public static void PrintCourseInfo(Course topCourse)
        {
            Console.CursorLeft = consoleLeftPad;
            Console.WriteLine(topCourse.Name);
            if (topCourse.ChildrenCourses != null)
            {
                foreach (var item in topCourse.ChildrenCourses)
                {
                    PrintCourseInfo(item);
                }
                consoleLeftPad += 1;
            }
        }
        public static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            Computer c = new Computer();
            c.Monitor = new Monitor()
            {
                MonitorName = "LPC"
            };
            c.SystemBlock = new SystemBlock()
            {
                SystemBlockDescription = "Acer"
            };
            dbContext.Computers.Add(c);

            dbContext.SaveChanges();

            Console.ReadLine();
        }
    }
}
