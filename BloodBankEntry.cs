﻿
namespace BloodBankManagementAPI.Models
{
    public class BloodBankEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string DonorName { get; set; }
        public int Age { get; set; }
        public string BloodType { get; set; }
        public string ContactInfo { get; set; }
        public int Quantity { get; set; } // in ml
        public DateTime CollectionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Status { get; set; } // Available, Requested, Expired
    }
}
