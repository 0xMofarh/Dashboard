using System;

namespace ProgrammToicx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] UserName = new string[0];
            string[] passwords = new string[0];
            string[] tempUser = new string[UserName.Length + 1];
            string[] tempPassword = new string[passwords.Length + 1];
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("======= Welcome To AcOn =======");
                Console.WriteLine("[1] Register Page");
                Console.WriteLine("[2] Login Page");
                Console.WriteLine("[3] Forget Password");
                Console.WriteLine("[4] Exit");
                Console.Write("\n\n[!] Choose Number : ");
                Console.Clear();
                int F = Convert.ToInt16(Console.ReadLine());

                switch (F)
                {
                    case 1: 
                        Console.Clear();
                        Console.WriteLine("======= Register Page =======");
                        Console.Write("[!] Enter UserName: ");
                        string UserN = Console.ReadLine();
                        Console.Write("[!] Enter Password: ");
                        string PassN = Console.ReadLine();
                        for (int j = 0; j < UserName.Length; j++)
                        {
                            tempUser[j] = UserName[j];
                            tempPassword[j] = passwords[j];
                        }
                        tempUser[tempUser.Length - 1] = UserN;
                        UserName = tempUser;

                        tempPassword[tempPassword.Length - 1] = PassN;
                        passwords = tempPassword;

                        Console.WriteLine("[!] User Registered: " + UserN);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("======= Login Page =======");

                        Console.Write("[!] Enter UserName: ");
                        string UserInput = Console.ReadLine();
                        Console.Write("[!] Enter Password: ");
                        string PasswordInput = Console.ReadLine();

                        bool found = false;
                        for (int i = 0; i < UserName.Length; i++)
                        {
                            if (UserInput == UserName[i] && PasswordInput == passwords[i])
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            Console.WriteLine("[!] Welcome sir " + UserInput);
                        }
                        else
                        {
                            Console.WriteLine("[X] Invalid username or password");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("======= Forgot Page =======");

                        Console.Write("[!] Enter Your Username : ");
                        string forgotUser = Console.ReadLine();

                        for (int s = 0; s < UserName.Length; s++) { 
                            if (forgotUser == UserName[s])
                            {
                                Console.WriteLine("[!] Found User ");
                                Console.WriteLine("[!] Enter New Password");
                                string passwd = Console.ReadLine();
                                passwords[s] = passwd;
                                break;
                            }

                        };
                        break;

                    case 4:
                        Console.WriteLine("[+] Goodbye!");
                        return;

                    default:
                        Console.WriteLine("[X] Invalid choice.");
                        break;
                }
            }
        }
    }
}
