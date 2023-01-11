using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int rollNo;
            string nm;
            Console.Write("\nId Barang: ");
            Console.Write("\nNama Barang: ");
            Console.Write("\nJenis Barang: ");
            Console.Write("\nHarga Barang: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;

            if (START == null || rollNo <= START.rollNumber)
            {
                Console.WriteLine("nDuplicate roll numbers not allowed");
                return;
            }
            newnode.next = START;
            if (START != null)
                START.prev = newnode;
            newnode.prev = null;
            START = newnode;
            return;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null && rollNo != current.rollNumber; previous = current, current = current.next)
            { }
            return (current != null);
        }

        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            DoubleLinkedList obh = new DoubleLinkedList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nDaftar Barang" +
                        "\n 1. Data yang disimpan" +
                        "\n 2. Berdasarkan Jenis Barang" +
                        "\n 3. Menampilkan semua data barang yang sama" +
                        "\n 4. Exit \n" +
                        "\n Enter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}




/* 2. Double linked list, karena algdritma ini dapat melakukan list  apa yang ingin kita lakukan bisa berupa barang nama ataupun lainnya*/
/* 3. Front, REAR */
/* 4. a. 18, b. Dari yang terkecil atau dari kiri bawah */