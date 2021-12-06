using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
     public class Mother:ISleep, IFamilyIssues, IEat
    {

        public void Eating()
        {
            Console.WriteLine("Mother is love to eat her foods");
        }
        public void FamilyIssues()
        {
            Console.WriteLine("About mother:  Nobody loves her foods and its make her sad");   
        }
        public void Sleeping()
        {
            Console.WriteLine("Mother love to sleep with her husband");
            Console.WriteLine("======================");
        }
    }
}
