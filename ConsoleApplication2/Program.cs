using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Teacher
    {
        private static List<int> asd = new List<int>();

        static Teacher()
        {
            asd.Add(1);
            asd.Add(2);
            asd.Add(3);
            asd.Add(4);
            asd.Add(5);
            asd.Add(6);
        }

        public Teacher()
        {

        }

        public static void print()
        {
            foreach(var item in asd)
            {
                Console.WriteLine(item);
            }
        }
    }

    abstract class Human
    {
        public virtual string getPermissionName()
        {
            return GetType().Name;
        }
    }


    class Stu: Human
    {
        public void onpt()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher.print();

            Console.WriteLine(new Stu().getPermissionName());

            byte asd = 200;

            try
            {
                unchecked
                {
                    asd += 100;
                }
            }
            catch (System.OverflowException ex)
            {

            }
        }
    }
}
