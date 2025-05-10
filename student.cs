using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public  class student
    {
        int id;
        string name;
        DateTime dob;
        string mobile;


        public student()             // deafault 
        {
            id = 0;
            name = "saisha";
            mobile = "unlnown";
        }

        public student(int aintid, string astrname , string astrmobile)      // parameterised
        {
            id = aintid;
            name = astrname;
            mobile = astrmobile;
        }

        public  void printinfo()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("name :" + name);
            Console.WriteLine("mobile :" + mobile);
        }



        //2
        public string nam;
        public int age;

        // Constructor
        public student( int personAge , string personName)
        {
            nam = personName;
            age = personAge;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {nam} and I am {age} years old.");
        }

        
    }
}
