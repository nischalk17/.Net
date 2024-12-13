using System;

namespace Database_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudOperation crud = new CrudOperation();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Table");
                Console.WriteLine("2. Insert Data");
                Console.WriteLine("3. Update Data");
                Console.WriteLine("4. Display Data");
                Console.WriteLine("5. Delete Data");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        crud.CreateTable();
                        break;
                    case "2":
                        crud.InsertData();
                        break;
                    case "3":
                        crud.UpdateData();
                        break;
                    case "4":
                        crud.DisplayData();
                        break;
                    case "5":
                        crud.DeleteData();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
