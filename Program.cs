using System;
using System.Data;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Transactions;
using Microsoft.VisualBasic;

namespace LinkedLists {
    class Program {
        static void Main(string [] args) {

            LinkedListOperations newLinked = new LinkedListOperations();
            newLinked.InsertFirstNode(55);
            newLinked.InsertFirstNode(88);
            newLinked.InsertFirstNode(99);
            newLinked.InsertFirstNode(77);
            newLinked.InsertFirstNode(44);
            newLinked.InsertFirstNode(44);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("inserting at the top of linkedlist");
            newLinked.PrintLinkedList();

            Console.WriteLine();
            Console.WriteLine();
            newLinked.InsertMiddle(77,33);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("inserting at the bottom linkedlist");
            newLinked.InsertLastNode(15);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("deleting from top of linkedlist");
            newLinked.RemoveFirstNode();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deleting from the bottom of linkedList");
            newLinked.DeletefromTail();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deleting from the Middle of linkedList");
            newLinked.DeletefromMiddle(99);


        }
    }

    class Node { // represents our first our first node 
        public int data{get; set;}
        public Node? Next {get; set;}
        public void DisplayNode()
        {
             Console.WriteLine(data);
        }

    }

    class LinkedListOperations{
        public Node? head {get; set; }
        public void InsertFirstNode(int data){
            
            var newNode = new Node();//we create a node to hold our insert values
            newNode.data = data; // we assing the data to the our new node

            if(head!=null){// check for the empty linkedlist
                newNode.Next = head;//make the newNode (next) reference originalNode
                head = newNode; // originaNode now can be labeled as head 
                head.DisplayNode();
            } else {
                newNode.Next = head; 
                head = newNode; //if it is null simply make the null head the newNode
                head.DisplayNode();      
            }
            
            
        }

        public void InsertMiddle(int data, int newData) {
            Node current = head; //helps with not updating head during traversal
            Console.WriteLine("inserting in the middle final list");

            while (current.data!= data) {
                Console.WriteLine(current.data);
                current = current.Next;
            }
            Node newNode = new Node(); //create node to hold data for our newNode
            newNode.data= newData;

            newNode.Next = current.Next; //assign the node we wants Next to the current Node next
            current.Next = newNode; // assign the current node reference to new Node
            newNode = current; //make newNode the currentNode in the linkedList

            while(current!=null){
                
                current.DisplayNode(); //remember display node is in our parent class node.
                current = current.Next;
            }
            Console.WriteLine(current);
        }


        public void InsertLastNode(int data) {
            Node current = head;

            Node lastinsert = new Node(); //we created a node to hold data for our newNode
            lastinsert.data = data; 

            while(current.Next!= null) { 
                Console.WriteLine(current.data);
                current= current.Next;
            }

            current.Next = lastinsert;
            while(current!=null){
                current.DisplayNode();
                current = current.Next;
            }
            
        }

        public void RemoveFirstNode() {
            Node current = head;// helps with not updating head during the traversal
            //we still have to create a newNode even if we are deleting
            Node newNode = new Node();
            newNode = current.Next; // make newNode
            //head = newNode;

            while(current.Next!=null){
                current = current.Next;
                current.DisplayNode();
            }

        }
        public void DeletefromMiddle(int data) {
            Node current = head; //helps prevent updating head during traversal
            Node prev = new Node();
            while (current.data!= data) { // print out our list till the part we want to delete
                Console.WriteLine(current.data);
                prev = current; //we use the prev node to track our previous node of the node we want to delete
                current = current.Next;
            }

            Node temp = new Node(); //we create a temp to avoid leaks
            temp = prev; // assign temp to the previous node
            temp.Next = current.Next; //align the reference with the rest to link with the next of the list 
            //prev.Next = temp;
        

            while(temp.Next!=null) { // print out rest of the list 
                temp = temp.Next;
                temp.DisplayNode(); 
            }
                Console.WriteLine(temp.data);

        }

        public void DeletefromTail() {
            Node current = head;
           
           while(current.Next!=null) { //iterate through the entire list till we reach last node
            current.DisplayNode(); 
            current = current.Next;
           }

           current = null; //I just med the node null
           Console.WriteLine();
           Console.WriteLine();   
        }

        
        public void PrintLinkedList () { // we call this to print out our current list
            Node current = head;

            while(current.Next!=null){
                
                current.DisplayNode();
                current = current.Next;
               //current.DisplayNode();
            }
            Console.WriteLine(current.data); // extra print for the last element
        }        
    }

    }