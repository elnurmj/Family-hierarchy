using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Daughter daughter = new Daughter();
            daughter.FamilyIssues();
            daughter.Eating();
            daughter.Sleeping();

            Son son = new Son();
            son.FamilyIssues();
            son.Eating();
            son.Sleeping();

            Father father = new Father();
            father.FamilyIssues();
            father.Eating();
            father.Sleeping();

            Mother mother = new Mother();
            mother.FamilyIssues();
            mother.Eating();
            mother.Sleeping();

        }
    }
}
