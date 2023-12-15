using System;
using System.Runtime.InteropServices;

namespace LinkedLists {
    class Program {
        static void Main(string [] args) {

            var najib = new Node();
            najib.data= 25;
            najib.DisplayNode();

            var pink = new Node();
            pink.data= 20;
            pink.DisplayNode();

            var azhar = new Node();
            azhar.data = 21;
            azhar.DisplayNode();

            najib.Next=pink;
            pink.Next = azhar;
            azhar.Next= null;
        }
    }

    class Node {
        public int data{get; set;}
        public Node? Next {get; set;}
        public void DisplayNode()
        {
             Console.WriteLine(data);
        }

    }




}