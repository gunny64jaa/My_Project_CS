using System;
using System.Collections;
using System.Collections.Generic;

    

namespace Myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member_list = new Members();
            bool flag = true;
            while(flag)
            {
                Console.Write("\nPress 1 if you want to keep the system running. \nPress 2 if you don't .\n");
                string input = Console.ReadLine();
                int run_process;
                int.TryParse(input,out run_process);
                switch(run_process)
                {
                    case 1 : {flag = true;break;}
                    case 2 : {flag = false;continue;}
                }

                
                Console.WriteLine("\nPress 1 for register.\nPress 2 for show all members.\nPress 3 for login\n");
                string input1 = Console.ReadLine();
                int output1;
                int.TryParse(input1,out output1);
                switch(output1)
                {
                    case 1 : {member_list.add_member();continue;}
                    case 2 : {member_list.show_member();break;}
                    case 3 : {member_list.login();break;}
                }
                
                
                
            }
        }
    }
}

