using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Father:ISleep, IFamilyIssues, IEat
    {

        public void Eating()
        {
            Console.WriteLine("Father is love to eat chicken");
        }
        public void FamilyIssues()
        {
            Console.WriteLine("About father:  Father is hate to argument with his wife, because wife is always in the true side");   
        }
        public void Sleeping()
        {
            Console.WriteLine("Father cant sleep because he is always dreaming about his crush");
            Console.WriteLine("======================");
        }
    }
}
