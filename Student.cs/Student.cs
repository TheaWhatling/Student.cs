using System;
using System.Collections.Generic;
using System.Text;

namespace Student.cs
{
    class Student // "static" is not used for objects in object orientated code but is for classes in other type of code 
    {
        private string name;
        private int IQ;
        private string predictedGrade; 

        public Student()
        {
            name = "bob";
            IQ = 0;
            predictedGrade = " ";
        }

        public Student(string name)
        {
            this.name = name;
            this.IQ = 0;
            this.predictedGrade = " ";
        }

        public Student(string name, int IQ)
        {
            this.name = name;
            this.IQ = IQ;
            this.predictedGrade = " ";
        }

        public Student(string name, int IQ, string predictedGrade)
        {
            this.name = name;
            this.IQ = IQ;
            this.predictedGrade = predictedGrade;
        }

        //public void gaming(int v)
        //{
        //    IQ = IQ - v;
        //}

        public void learn(int hours)
        {
            IQ = IQ + hours;
        }

        public void setpredictedGrade(string p)
        {
            
            p = " ";

            if (IQ > 150)
            {
                p = "A*";
            }
            else p = "A";

            predictedGrade = p;

        }

        public string getpredictedGrade()
        {
            return predictedGrade;
        }

        public void setName(string n)
        {
            name = n;
        }

        public string getName()
        {
            return name;
        }

        public void setIQ(int x)
        {
            IQ = x;
        }

        public int getIQ()
        {
            return IQ;
        }

        public void print()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("IQ: " + IQ);
            Console.WriteLine("predicted grade: " + predictedGrade);
        }

    }

}
