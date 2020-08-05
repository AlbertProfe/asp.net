using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public static class Menu
    {
        public static void OptionMenu(People people)
        {
            while (true)
            {
                Menu.ShowMenu();
                Console.Write("Choose one option:");
                String command = Console.ReadLine();

                if (command.Equals("quit"))
                {
                    break;
                }
                else if (command.Equals("createAccount"))
                {
                    CreateAccount(people);
                }
                else if (command.Equals("addAccount"))
                {
                    //addAccount(people);
                }
                else if (command.Equals("deposit"))
                {
                    Deposit(people);
                }
                else if (command.Equals("withdraw"))
                {
                    //todo
                }
                else if (command.Equals("transfer"))
                {
                    Transfer(people);
                }
                else if (command.Equals("printAccount"))
                {
                    //todo
                }
                else if (command.Equals("printPeople"))
                {
                    people.PrintPeople();
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Unknown command!");
                }
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\tcreateAccount - you may create a Bank Account");
            Console.WriteLine("\taddAccount - ...............");
            Console.WriteLine("\tdeposit - ...............");
            Console.WriteLine("\twithdraw - ...............");
            Console.WriteLine("\ttransfer - ...............");
            Console.WriteLine("\tprintAccount - ...............");
            Console.WriteLine("\tprintPeople - print on screen all persons on people list ");
            Console.WriteLine("\tquit - exit program \n");
        }

        static void CreateAccount(People people)
        {
            Console.Clear();
            Console.WriteLine("Create account");
            Console.WriteLine("-----------------------------");

            Console.Write("\tidAccount: ");
            String idAccount = Console.ReadLine();

            Console.Write("\tbank: ");
            String bank = Console.ReadLine();

            Console.Write("\tcurrency: ");
            String currency = Console.ReadLine();

            Console.Write("\tbalance: ");
            double balance = double.Parse(Console.ReadLine());


            Account newAccount = new Account(idAccount, balance, bank, currency);

            AddAccount(newAccount, people);

        }

        static void AddAccount(Account newAccount, People people)
        {

            //Console.Clear();
            Console.WriteLine("\nAdd account");
            Console.WriteLine("-----------------------------");

            //Console.Write("idAccount: ");
            //String idAccount = Console.ReadLine();

            bool exist = false;

            while (!exist)
            {
                Console.Write("\n\tperson Name: ");
                String personName = Console.ReadLine();

                foreach (Person p in people.peopleArray)
                {
                    if (p.getName() == personName)
                    {
                        p.setAccount(newAccount);
                        exist = true;
                        Console.WriteLine("Account " + newAccount.idAccount + " added to " + p.getName());
                        Console.WriteLine("Press any key to exit or go to try again");
                        Console.ReadKey();
                    }
                }

                if (!exist)
                {
                    Console.Write("\t" + personName + " does NOT exist in our list.");
                    Console.WriteLine("Press any key to exit or go to try again");
                    String command = Console.ReadLine();
                    if (command != "go") exist = true;
                }
            }
        }

        static void Deposit(People people)
        {
            Console.Clear();
            Console.WriteLine("Deposit");
            Console.WriteLine("-----------------------------");

            bool exist = false;
            while (!exist)
            {
                // (1) preguntar al usuario por el nombre del person a realizar un deposito
                Console.Write("\n\tperson Name: ");
                String personName = Console.ReadLine();

                // (2)  existe ese person? existe en nuestra lista people?
                foreach (Person p in people.peopleArray)
                {
                    // (3)  si es que si, ENTONCES preguntar al usuario el dinero a ingresar
                    if (p.getName() == personName)
                    {
                        Console.Write("\n\tHow much money to deposit: ");
                        double amount = double.Parse(Console.ReadLine());

                        //  (3.1) realizar el ingreso
                        bool s = p.account.Deposit(amount);

                        //   (3.2) informar que el ingreso ha sido realizado
                        Console.WriteLine("Amount deposited " + s + ": " + amount + " to " + p.account.idAccount + " added to " + p.getName());
                        Console.WriteLine("Total balance: " + +p.account.balance);
                        Console.WriteLine("Press any key to exit or go to try again");
                        Console.ReadKey();
                    }
                }
                if (!exist)
                {
                    //  (4) si es que no, ENTONCES pregunar si quiere salir y volver al menu principal
                    Console.Write("\t" + personName + " does NOT exist in our list.");
                    Console.WriteLine("Press any key to exit or go to try again");
                    String command = Console.ReadLine();
                    if (command != "go") exist = true;
                }
            }

        }

        static void Transfer(People people)
        {

            Console.Clear();
            Console.WriteLine("Tranfer");
            Console.WriteLine("-----------------------------");

            bool exist = false;
            while (!exist)
            {
                // (1) preguntar al usuario por el nombre del person a realizar al transfe
                Console.Write("\n\tperson Name: ");
                String fromName = Console.ReadLine();
                // (2)  existe ese person? existe en nuestra lista people?
                foreach (Person p in people.peopleArray)
                {
                    // (3)  si es que si, ENTONCES preguntar al usuario el dinero a ingresar
                    if (p.getName() == fromName)
                    {
                        Console.Write("\n\tHow much money to transfer: ");
                        double amount = double.Parse(Console.ReadLine());

                        String account = Console.ReadLine();
                        //  (3.1) realizar el ingreso
                        bool s = p.account.Transfer(p, , amount);

                        //   (3.2) informar que el ingreso ha sido realizado
                        Console.WriteLine("Transfer deposited " + s + ": " + amount + " to " + p.account.idAccount + " added to " + p.getName());
                        Console.WriteLine("Total balance: " + +p.account.balance);
                        Console.WriteLine("Press any key to exit or go to try again");
                        Console.ReadKey();
                    }
                }
                if (!exist)
                {
                    //  (4) si es que no, ENTONCES pregunar si quiere salir y volver al menu principal
                    Console.Write("\t" + fromName + " does NOT exist in our list.");
                    Console.WriteLine("Press any key to exit or go to try again");
                    String command = Console.ReadLine();
                    if (command != "go") exist = true;
                }







            }
        }

        static bool checkPerson(Person person) {
            return true;
        }

        static bool checkAccount(Person person) {
            return true;
        }
    }
}
