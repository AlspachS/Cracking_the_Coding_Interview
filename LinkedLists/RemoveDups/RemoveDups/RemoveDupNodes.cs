using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDups
{
    public class RemoveDupNodes
    {

        public LinkedList<string> PerformRemovalWBuffer(LinkedList<string> unsortedList)
        {
            HashSet<string> nodeValues = new HashSet<string>();
            LinkedListNode<string> traveler = unsortedList.First;

            for (int i = 0; i < unsortedList.Count; i++) // while( traveler.Next != null )
            {
                if (!nodeValues.Add(traveler.Value))
                {
                    Console.WriteLine("Found Duplicate");
                    traveler = traveler.Next;
                    unsortedList.Remove(traveler.Previous);
                }
                if (traveler.Next != null)
                {
                    traveler = traveler.Next;
                }
            }

            return unsortedList;
        }

        public LinkedList<string> PerformRemovalWOBuffer(LinkedList<string> unsortedList)
        {
            LinkedListNode<string> tortise = unsortedList.First;
            LinkedListNode<string> hare = unsortedList.First;

            for (int j = 0; j < unsortedList.Count; ++j) // while( tortise.Next != null )
            {
                for (int i = j; i < unsortedList.Count; ++i) // while( hare.Next != null )
                {
                    if (hare.Next != null)  // Using the while would make this check the loop driver
                    {
                        hare = hare.Next;
                        if (tortise.Value == hare.Value)
                        {
                            Console.WriteLine("Found Duplicate");
                            hare = hare.Next;
                            unsortedList.Remove(hare.Previous);
                        }
                    }
                }

                tortise = tortise.Next;
                hare = tortise;
            }

            return unsortedList;
        }
    }
}
