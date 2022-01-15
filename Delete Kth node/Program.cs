using System;

namespace CSharpAlgorithms.DeleteFromKthNode {
    class CustomLinkedList {
        Node head;
        public class Node {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }

        public void deleteKthNodeFromEnd(int k){
            if(head == null || k == 0){
                return;
            }
            
            Node first = head;
            Node second = head;

            for(int i = 0; i < k; i++) {
                second = second.next;
                if (second.next == null){
                    // K >= Length of List
                    if(i == k - 1){
                        head = head.next;
                    }
                    return;
                }
            }

            while(second.next != null) {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
        }

        public void displayContents() {
            Node current = head;
            while(current != null) {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine("NULL");
        }

        static void Main(string[] args) {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedList.displayContents();
            linkedList.deleteKthNodeFromEnd(2);
            linkedList.displayContents();
        }
    }
}