using System;

namespace Student.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student v, v1;                   // classes are always capital letters

            //v = new Student();
            //v1 = new Student();

            string enteredname = " ";
            Console.WriteLine("please enter students name");
            enteredname = Console.ReadLine();

            
            Student[] s = new Student[s];

            for (int x = 0; x < 10; x = x + 1)
            {
                s[x].setName(enteredname);
                s[x].setIQ(110);                //for now random value
                s[x].setpredictedGrade("A");    //for now random value
            }
            

            int hoursinput = 0;
            Console.WriteLine("enter the number of hours " + s[x].getName() + " has worked"); // change so v can change 
            hoursinput = Convert.ToInt32(Console.ReadLine());
            s[x].learn(hoursinput);

            Console.WriteLine("student information: " + s[x].print());
        }
    }
}