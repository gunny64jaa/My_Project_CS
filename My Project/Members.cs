using System;
using System.Collections;
using System.Collections.Generic;

    

namespace Myproject
{
    class Members
    {
        Hashtable member_list = new Hashtable();
        public void add_member()
        {
            bool flag = true ;
            while(flag)
            {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string pass = Console.ReadLine();

            try{member_list.Add(name,pass);flag=false;}
            catch (Exception e){Console.WriteLine("Error plese try again!");}
            }
        }
        public void show_member()
        {
            Console.Write("\nAre you admin ? \npress 1 if yes  \npress 2 if not\n");
            string input_admin = Console.ReadLine();
            int admin;
            int.TryParse(input_admin,out admin);
            switch(admin)
            {
                case 1 : 
                {foreach (string key in member_list.Keys)
                        {Console.WriteLine("("+key+":"+member_list[key]+")");}break;}
            }
            
        
        }
        public void login()
        {
            bool login_check = true;
            while(login_check)
            {
            Console.Write("Enter your name (press 0 if wanna quit): ");
            string login_name = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string login_password = Console.ReadLine();
            string pass_check ;
            pass_check=Convert.ToString(member_list[login_name]);
            if (member_list.ContainsKey(login_name))
                {
                if ( login_password == pass_check ) 
                    {Console.WriteLine("You are already logged in as member");
                    
                    login_check = false;}
                else{Console.WriteLine("Your password is incorrect.");Console.WriteLine(login_password+member_list[login_name]);}
                }
            else if (login_name == "0"){login_check = false;}
            else{Console.WriteLine("Your username is not found.");}
            }
        }
    }
}    

