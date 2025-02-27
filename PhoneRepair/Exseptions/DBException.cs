using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneRepair.Exseptions
{
    public class DBException : Exception
    {
        public DBException() : base()
        {
            ID = Guid.NewGuid().GetHashCode().ToString();
        }
        public DBException(Exception e) : base("DBException", e)
        {
            ID = Guid.NewGuid().GetHashCode().ToString();
        }
        public string ID 
        {
            get;
            private set;
        }
    }
}