using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public string Phone { get; set; }
        [DisplayName("Cpf/Cnpj")]
        public string CpfCnpj { get; set; }
        [DisplayName("Address")]
        public string  Address { get; set; }
        [DisplayName("Person Type")]
        public string PersonType { get; set; }

        public Client() { }

        public Client(int id, string name, DateTime date, string phone, string cpfCnpj, string address)
        {
            Id = id;
            Name = name;
            Date = date;
            Phone = phone;
            CpfCnpj = cpfCnpj;
            Address = address;
        }
    }
}
