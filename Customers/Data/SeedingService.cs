using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Models;

namespace Customers.Data
{
    public class SeedingService
    {
        private CustomersContext _context;

        public SeedingService(CustomersContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Client.Any())
            {
                return; //DB já populado
            }

            List<Client> lista = new List<Client>();
            List<string> nomes = new List<string>() { "João", "Gabriel", "Maria", "Renato","Beatriz", "Micael", "Hélio", "Alcides",
                "Ana", "Alzenira"};

            Random r = new Random();
            int index = r.Next(nomes.Count);
            string randomString = nomes[index];

            for (int i = 0; i < 100; i++)

            {
                lista.Add(new Client(i, randomString, new DateTime(2001, 07, 07), "81998659979", "13507873508", "R.Medeiros"));
            }

            _context.Client.AddRange(lista);

            _context.SaveChanges();
        }
    }
}
