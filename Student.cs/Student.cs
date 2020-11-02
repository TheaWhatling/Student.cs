using System;
using System.Collections.Generic;
using System.Text;

namespace Student.cs
{
    class Student // "static" is not used for objects in object orientated code but is for classes in other type of code 
    {
        private string name;
        private int IQ;

        public Student()
        {
            name = "bob";
            IQ = 100;
        }

        public Student(string name)
        {
            this.name = name;
            this.IQ = -100; 
        }

        public Student(string name, int IQ)
        {
            this.name = name;
            this.IQ = IQ;
        }

        public void gaming(int v)
        {
            IQ = IQ - v;
        }

        public void learn(int hours)
        {
            IQ = IQ + hours;
        }

        public void predictedGrade()
        {
            string p;
            p = " ";

            if (IQ > 150)
            {
                p = " A* ";
            }
            else p = "A";

        }


        public void setName(string n)
        {
            name = n;
        }

        public string getName()
        {
            return name;
        }
    }

}
