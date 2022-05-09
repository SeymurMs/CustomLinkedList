using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    internal class CstLinkedList<T>
    {
        Node<T> root= null;
        Node<T> tail= null;
        
        public void Add(T data)
        {
            Node<T> type = new Node<T>();
            type.data = data;
            type.next = null;
            if (root ==null)
            {
                root = type;
                tail = type;
                Console.WriteLine("List added");
                return;
            }
            else
            {
                tail.next = type;
                tail = type;
                Console.WriteLine("list already exists and added");

            }
        }

       public void ShowInfo()
        {
            if (root == null)
            {
                Console.WriteLine("Root is not added");
            }
            else
            {
                Node<T> temp = root;
                while (root != null)
                {
                   
                   Console.WriteLine(temp.data);
                    temp = temp.next;
                    if (temp == null)
                    {
                        break;
                    }
                }
            }
           
        }
    }
}
