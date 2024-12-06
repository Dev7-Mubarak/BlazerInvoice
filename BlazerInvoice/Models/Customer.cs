﻿namespace BlazerInvoice.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
