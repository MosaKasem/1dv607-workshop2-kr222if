using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Member member = new Member();
            try {
            member.PersonalNumber = -1;
            } catch (Exception Ex) {
                Console.WriteLine(Ex);
            } 
            Console.WriteLine(member.PersonalNumber);
        }
    }
}
