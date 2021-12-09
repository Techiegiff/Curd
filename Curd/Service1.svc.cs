using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace Curd
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public InsertUser Insert(InsertUser user)
        {
            SqlConnection sqlcon = new SqlConnection("server=DIOEAMORA;database=ustglobaldb;Integrated Security=true");
            sqlcon.Open();
            SqlCommand smd = new SqlCommand("insert into BOOK(BookId,BookName,BookAuthor,BookPrice) values(@bid,@bnm,@bauth,@bp)", sqlcon);
            smd.Parameters.AddWithValue("@bid", user.BookID);
            smd.Parameters.AddWithValue("@bnm", user.BookName);
            smd.Parameters.AddWithValue("@bauth",user.BookAuthor);
            smd.Parameters.AddWithValue("@bp", user.BookPrice);
            smd.ExecuteNonQuery();
            return user;
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        InsertUser IService1.GetDataUsingDataContract(InsertUser user)
        {
            throw new NotImplementedException();
        }
    }
}
