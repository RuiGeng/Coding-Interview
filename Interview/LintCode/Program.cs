using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.Next = new ListNode(1);
            listNode.Next.Next = null;
            Console.WriteLine(Code452.RemoveElements(listNode, 1));
            Console.ReadLine();
        }
    }
}
