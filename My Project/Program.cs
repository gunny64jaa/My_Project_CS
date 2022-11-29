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
            bool status = false;
            while(flag)
            {
                Console.WriteLine("\nPress 1 for register.");
                Console.WriteLine("Press 2 for show all members.");
                Console.WriteLine("Press 3 for login.");
                Console.WriteLine("Press 4 for logout.");
                Console.WriteLine("Press 5 for show status.");
                Console.WriteLine("Press 6 for queue request.");
                Console.WriteLine("Press 7 for show all queue and table.");
                Console.WriteLine("Press 8 for leaving.");
                string input = Console.ReadLine();
                int run_process;
                int.TryParse(input,out run_process);
                switch(run_process)
                {
                    case 1 : 
                    {
                        member_list.add_member();
                        flag = true;break;
                    }
                    case 2 : 
                    {
                        member_list.show_member();
                        flag = true;break;
                    }
                    case 3 :
                    {
                        member_list.login();
                        if (member_list.is_login()==1)
                        {
                            status=true;
                        }
                        else
                        {
                            status=false;
                        }
                        flag = true;break;
                    }
                    case 4 :
                    {
                        member_list.logout();
                        status=false;
                        flag = true;break;
                    }
                    case 5 :
                    {
                        if(status){Console.WriteLine("================\nYou're logging in.\n================");}
                        else{Console.WriteLine("======================\nYou're not logging in.\nPlease login.\n======================");}
                        flag = true;break;
                    }
                    case 8 : 
                    {
                        flag = false;continue; 
                    }       
                }   
            }
        }
    }
}
