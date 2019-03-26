using System;
using System.Collections.Generic;
using System.Text;

namespace SpaDatasource.Entitites
{
    public class Order
    {
        public int Id;
        public int UserId;
        public string Description;
        public DateTime CreateDate;
        public DateTime PayDate;
        public bool IsShipped;
        public bool IsCanceled;
    }
}
