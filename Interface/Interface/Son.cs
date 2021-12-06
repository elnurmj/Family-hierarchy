using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Son : ISleep, IFamilyIssues, IEat
    {

        public void Eating()
        {
            Console.WriteLine("Son is love to eat hamburger");
        }
        public void FamilyIssues()
        {
            Console.WriteLine("About son:  He wants to be soccer player but his father dont let him be");
        }
        public void Sleeping()
        {
            Console.WriteLine("He cant close his eyes while sleeping and he looks so scary");
            Console.WriteLine("======================");
        }
    }
}
