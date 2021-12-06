using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
   public class Daughter:ISleep, IFamilyIssues, IEat
    {

        public void Eating()
        {
            Console.WriteLine("Daughter is love to eat pizza");
        }
        public void FamilyIssues()
        {
            Console.WriteLine("About daughter:  Daughter hate her brother");  
        }
        public void Sleeping()
        {
            Console.WriteLine("Daughter is sleeping to late");
            Console.WriteLine("======================");
        }
    }
}
