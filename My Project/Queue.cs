using System;
using System.Collections;
using System.Collections.Generic;

    

namespace Myproject
{
    class Queue
    {
        int[] table = new int[10];
        int reserved_seat = 0 ;
        int total_queue = 0 ;
        public void show_queue()
        {
            for (int i = 0; i < table.Length; i++){reserved_seat += table[i];}
            int not_reserved_seat = table.Length-reserved_seat;
            Console.WriteLine("-----------------------------------------");
            Console.Write("| ");
            foreach(int q in table)
            {
                {Console.Write(q+" | ");}
            }
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("There are "+not_reserved_seat+" empty seats in total.");
            Console.WriteLine("There are "+total_queue+" queue in total.\n");
            reserved_seat=0;
        }
        public void q_in()
        {
            int reserved_seat1=0;
            for (int i = 0; i < table.Length; i++){reserved_seat1 += table[i];}
            if (reserved_seat1 >= table.Length)
            {
                total_queue +=1;
                Console.WriteLine("You're already queued,please wait for a second. ");
            }
            else
            {
            Console.WriteLine("What number of seat would you like (1-10) ?,");
            
            

            bool flag = true ;
            while (flag)
            {            
                Console.Write("Number of seat : ");
                string seat_input = Console.ReadLine();
                int seat;
                int.TryParse(seat_input,out seat);
                if (table[seat-1]==0){table[seat-1]=1;flag=false;}
                else 
                {
                    if (total_queue > 0){flag=false;break;}
                    Console.WriteLine("This table is not avaliable pls choose others.");
                }
            }
            
            }
        }
        public void q_out()
        {
            int reserved_seat2=0;
            for (int i = 0; i < table.Length; i++){reserved_seat2 += table[i];}
            Console.WriteLine("Type the number of seat that costomer leaving. (1-10)");
            Console.Write("Number of seat : ");
            string seat_input = Console.ReadLine();
            int seat;
            int.TryParse(seat_input,out seat);
            table[seat-1]=0;
            if (reserved_seat2 >= table.Length)
            {
                Console.Write("(for queuing )");
                total_queue -=1;
                q_in();
            }        
        }
    }
}