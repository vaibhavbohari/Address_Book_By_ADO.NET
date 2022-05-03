using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AddressBookADO.Net
{
    public class AddressBookRepo
    {

        public void CreateDataBase()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-N926GS71;Initial Catalog=master;Integrated Security=True");

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create DataBase AddressBookService", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Address Book Created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured by Connection Database while creating DB");
            }
            finally
            {
                connection.Close();
            }
        }


        public  void CreateTable()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-N926GS71;Initial Catalog=AddressBookService;Integrated Security=true;");

            try
            {
                
                SqlCommand cmd = new SqlCommand("create table AddressBook(Id int identity(1,1)Primary key,FirstName varchar (50),LastName varchar(50),Address varchar(50),City varchar(50),State varchar(50),Zip varchar(50),PhoneNumber Bigint,AddressBookName varchar(50),AddressBookType varchar(50),EmailId varchar(50))", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Address Book Table Created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured by Connection Database while creating DB");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}





























