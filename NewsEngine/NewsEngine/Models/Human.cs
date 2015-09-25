using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsEngine.Models
{
    public class Human
    {
        string name;
        int age;
        string birthPlace;

        public Human(string name, int age, string birthPlace)
        {
            this.name = name;
            this.age = age;
            this.birthPlace = birthPlace;
        }

        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public string getBirth()
        {
            return birthPlace;
        }
    }
}