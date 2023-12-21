using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class ItalianChef: Chef //The Chef is Inhertance from Class Chef
    {
        public void MakePasta() 
        {
            Console.WriteLine("The ItalianChef makes Pasta");
        }
        public override void MakeSpecialDish()// This Methode override the virtual from class Chef
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
