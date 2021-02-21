using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;//add windows Form Library

namespace DATASTRUCTURES
{
    public class ListNode
    {
        public string data;
        public ListNode nextnode;

        public ListNode(string Cast)
        {
            data = Cast;
            nextnode = null;
        }
    }

    public class MyStringList
    {
        ListNode Start;

        public MyStringList()
        {
            Start = null;
        }

        public void add(string Value)
        {
            ListNode temp = new ListNode(Value);
            if (Start == null)
            {
                Start = temp;
            }
            else 
            {
                ListNode P = Start;
                while (P.nextnode != null) 
                {
                    P = P.nextnode;
                }
                P.nextnode = temp;
            }
        }
        public string Display()
        {
            string List = "";
            ListNode current = Start;
            if (current == null)
                return "List is empty";

            while (current != null)
            {
                List += "\r\n " + current.data +",";
                current = current.nextnode;
            }
            return List;

        }
        //public ListNode Delete_Full_Node_Of_Single_List()
        //{
        //    if (Start == null)
        //        return null;


        //    return data;
        //}
        public string Search(string cast)
        {
            ListNode curr = Start;
            string value = "";

            while (curr != null)
            {
                if (cast.CompareTo(curr.data) == 0)
                {

                    value = " "+curr;
                    return cast;

                }

                curr = curr.nextnode;
            }

            return "Not found in List";


        }


    }

}



