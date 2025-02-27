using System;


namespace PhoneRepair.Exseptions
{
    public class OrderRepositoryException : DBException
    {
        public PhoneOrder Order 
        {
            get;
            private set; 
        }
        public OrderRepositoryException(PhoneOrder o, Exception e): base(e) 
        { 
            Order = o;
        }

        public OrderRepositoryException(PhoneOrder o) : base()
        {
            Order = o;
        }
    }
}