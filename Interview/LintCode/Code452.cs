namespace LintCode
{
    public class Code452
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="head">a ListNode</param>
        /// <param name="val">An integer</param>
        /// <returns>a ListNode</returns>
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode newHead = new ListNode(0);
            newHead.Next = head;
            ListNode cur = newHead;

            while (cur.Next != null)
            {
                if (cur.Next.Val == val)
                {
                    cur.Next = cur.Next.Next;
                }
                else
                {
                    cur = cur.Next;
                }
            }
            return newHead.Next;
        }
    }

    public class ListNode
    {
        public ListNode Next;
        public int Val;

        public ListNode(int x)
        {
            Val = x;
        }
    }
}