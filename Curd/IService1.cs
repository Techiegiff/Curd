using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Curd
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        InsertUser GetDataUsingDataContract(InsertUser user);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class InsertUser
    {
        string Bookname = string.Empty;
        int Bookid = int.Parse(string.Empty);
        string Bookauthor = string.Empty;
        float Bookprice = float.Parse(string.Empty);

        [DataMember]
        public int BookID
        {
            get { return Bookid; }
            set { Bookid = value; }
        }

        [DataMember]
        public string BookName
        {
            get { return Bookname; }
            set { Bookname = value; }
        }
        [DataMember]
        public string BookAuthor
        {
            get { return Bookauthor; }
            set { Bookauthor = value; }
        }
        [DataMember]
        public float BookPrice
        {
            get { return Bookprice; }
            set { Bookprice = value; }
        }
    }
}
