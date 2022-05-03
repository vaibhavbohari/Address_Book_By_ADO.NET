using System;

namespace AddressBookADO.Net
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================= Welcome To Address Book Using ADO Dot Net =======================");


            Console.WriteLine("Welcome to AddressBookSystem using Ado.net");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.CreateTable();
            
        }
    }
}
        
    
