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
    }


        
























        //@"Data Source=LAPTOP-N926GS71;Initial Catalog=AddressBookService;Integrated Security=true;";











        //public void checkConnection()
        //{
        //    try
        //    {
        //        this.connection.Open();
        //        Console.WriteLine("connection established");
        //        this.connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //    }
        //}

        //public void CreateTable()
        //{
        //    try
        //    {
        //        using (this.connection)
        //        {
        //            SqlCommand cm = new SqlCommand("create table contacts(FirstName varchar(16),LastName varchar (16),Address varchar(24),City varchar(16),State verchar (16),ZipCode int(16),PhoneNumber long (16),EmailID verchar (24))", connection);


        //            this.connection.Open();
        //            //Executing the SQL Query

        //            cm.ExecuteNonQuery();
        //            //Displaying a message
        //            Console.WriteLine("Table created Sucessfully");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("OOPS , Something went wrong ."+e);
        //    }
        //    finally
        //    {
        //        connection .Close() 
        //    }


        //}
        ////public bool addNewContactToDataBase(AddressBookModel addressBookModel)
        ////{
        ////    try
        ////    {
        ////        using (this.connection)
        ////        {
        ////            SqlCommand cmd = new SqlCommand("SpAddAddressBookDetail", this.connection);
        ////            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        ////            cmd.Parameters.AddWithValue("@FirstName", addressBookModel.FirstName);
        ////            cmd.Parameters.AddWithValue("@LastName", addressBookModel.LastName);
        ////            cmd.Parameters.AddWithValue("@Address", addressBookModel.Address);
        ////            cmd.Parameters.AddWithValue("@City", addressBookModel.City);
        ////            cmd.Parameters.AddWithValue("@State", addressBookModel.State);
        ////            cmd.Parameters.AddWithValue("@Zip", addressBookModel.Zip);
        ////            cmd.Parameters.AddWithValue("@PhoneNo", addressBookModel.PhoneNumber);
        ////            cmd.Parameters.AddWithValue("@Email", addressBookModel.Email);
        ////            cmd.Parameters.AddWithValue("@AddressBookName", addressBookModel.AddressBookName);
        ////            cmd.Parameters.AddWithValue("@AddressBookType", addressBookModel.AddressBookType);
        ////            this.connection.Open();
        ////            var result = cmd.ExecuteNonQuery();
        ////            this.connection.Close();
        ////            if (result != 0)
        ////            {
        ////                return true;
        ////            }
        ////            return false;
        ////        }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        throw new Exception(e.Message);
        ////    }
        ////    finally
        ////    {
        ////        this.connection.Close();
        ////    }
        ////}
    }


