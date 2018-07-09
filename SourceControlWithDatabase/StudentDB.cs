using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlWithDatabase
{
    class StudentDB
    {
        public static void DeleteStudent(int id)
        {
            SqlConnection con = new SqlConnection("con string here");

            SqlCommand delCmd = new SqlCommand();

            delCmd.Connection = con;

            delCmd.CommandText = "DELETE QUERY";

            try
            {
                con.Open();

                int rows = delCmd.ExecuteNonQuery();
            }
            catch// we should catch specific exceptions
            {
               //empty catch is typically not a good idea
            }
            finally
            {
                con.Dispose(); //this calls close internally 
            }
            //Same as above but no catch // REMOVE UNUSED CATCH 
            try
            {
                con.Open();
                //continue code here....
            }
            finally
            {
                con.Dispose();
            }
            //using statement
            //generates a try/finally Block
            //Inside the finally, Dispose() is called
            using(SqlConnection con2 = new SqlConnection())
            {
                con2.Open();
                //other DB code here...
            }//Dispose() is automatically called at the end
        }
    }
}
