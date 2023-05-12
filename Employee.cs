using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Employee
    {

        //Fields
        private int age;
        private string name;
        private int salary;

        public Gender Gender { get; set; }
        public Courses Courses { get; set; }

        //auto implemented properites
        public int Age
        {
            get
            {

                return this.age;
            }
            set
            {
                if (value >= 21)
                {
                    this.age = value;
                }
            }
        }




        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value >= 10000)
                {
                    this.salary = value + (value * 10 / 100);
                }
                else
                {
                    this.salary = value;
                }
            }
        }


        //public void SetAge(int? _age)
        //{
        //    if (_age != null && _age >= 21)
        //    {
        //        this.age = _age;
        //    }
        //}


        //public int? GetAge()
        //{

        //    if (Session["Teacher"] == true)
        //    {
        //        return this.age;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}





    }
}
