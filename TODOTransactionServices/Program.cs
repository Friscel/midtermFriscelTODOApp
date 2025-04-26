using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODODataService;

namespace Midterm
{
    internal class Program
    {
        static void Main string[] tasks = new string[] { "[1] Add Task", "[2] Delete Task", "[3] Edit Task"}
        {

            Console.WriteLine("WELCOME!!, Do you have task to Register?");
            int task = Convert.ToUInt16(Console.ReadLine);

            do
            {
                DisplayOptions();
            }
            while (task > 0);

            {
                if (task == 1)
                {
                    TaskDataService.AddTask();
                }

            }
        }
        public static void DisplayOptions()
        {
            string[] tasks;

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
        public void AddOptions()
        {
            string[] tasks;

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
