using System;

namespace Student.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Student v, v1;                   // classes are always capital letters
            v = new Student(bill, 110);
            //v.getName();
            //Console.WriteLine(v);

            v1 = new Student();
            //v1.getName();
            //Console.WriteLine(v1);

            v.setName("bill");
            v.setName("ben");

            Console.WriteLine(v.getName());

            for(int x = 0; x < 10; x = x + 1)
            {
                v.learn(1);
            }

            Console.WriteLine(v.getName() + "  " + v.predictedGrade());
        }
    }
}
