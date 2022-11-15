using System;
namespace instrumentRentals.Models
{
    public class rentalAgreement
    {
        public int id;
        public DateTime rentalStart = DateTime.MaxValue;
        public instrument instrument;
        public customer customer;
    }
}

