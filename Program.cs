using System;

namespace Csharp12
{
    class employee
    {
        public int empId;
        public string empName;
        public string empType;
        public employee(int pId, string pName, string pType)
        {
            empId = pId;
            empName = pName;
            empType = pType;
        }
        public double payment()
        {
            if(empType == "M-E")
            {
                double a,b,c;
                int grossSalary=9000;
                a=(grossSalary*18)/100;
                b=grossSalary-a;
                c=b*3/100;
                return (b-c);


            }
            else if(empType == "T-E")
            {
                double d;
                int grossSalary=9600;
                d=grossSalary*18/100;
                return (grossSalary-d);
            } 
            else{
                double e,f,g;
                int grossSalary=3800;
                e=(grossSalary*18/100);
                f=grossSalary-e;
                g=(f*0.15)/100;
                return (g+f); 
            }           
        }
        static void Main(string[] args)
        {
           
           
            employee employee1 = new employee(1, "merci", "M-E");
            employee employee2 = new employee(2, "jose", "M-E");
            employee employee3 = new employee(3, "olivier", "T-E");
            employee employee4 = new employee(4, "baby", "T-E");
            employee employee5 = new employee(5, "divine", "E-E");
            employee employee6 = new employee(6, "didy", "E-E");
            Console.WriteLine(employee3.payment());
            Console.WriteLine("welcome again!");
        }
    }
}
