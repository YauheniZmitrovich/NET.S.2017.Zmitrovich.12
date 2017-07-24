using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Logic;

namespace Task1.ConsoleUI
{
    public sealed class Teacher
    {
        public string Name { get; set; }

        public void SayLessonIsOver(object sender, TimeIsOverEventArgs e)
        {
            Console.WriteLine($"{e.Msg}? Call, it's for a teacher. Pay your attention to the blackboard, please.");
        }
    }

    public sealed class Student
    {
        public string Name { get; set; }

        public void SayLessonIsOver(object sender, TimeIsOverEventArgs e)
        {
            Console.WriteLine($"{e.Msg}! Time is out! It's time to rest!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer {Time = 5};
            var vasya = new Student {Name = "Vasya"};
            var angryTeacher = new Teacher {Name = "Zoya Vasilievna"};

            timer.TimeIsOver += vasya.SayLessonIsOver;
            timer.TimeIsOver += angryTeacher.SayLessonIsOver;
            
            timer.Start("Time of lesson - 5min.");
        }
    }
}
