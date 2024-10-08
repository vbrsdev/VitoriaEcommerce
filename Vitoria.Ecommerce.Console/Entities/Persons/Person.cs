using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitoria.Ecommerce.Console.Entities.Persons
{
    public class PersonRead   //criando classe no C#
    {
        public int PersonId { get; set; } //propriedade

        public int PersonType { get; set; }

        public string PersonName { get; set; }

        public string PersonCPFCNPJ { get; set; }

        public string PersonAddress { get; set; }

    }

    public class PersonCreate
    {
        public int PersonType { get; set; }

        public string PersonName { get; set; }

        public string PersonCPFCNPJ { get; set; }

        public string PersonAddress { get; set; }

    }

    public class PersonUpdate   //criando classe no C#
    {
        public int PersonId { get; set; } //propriedade

        public int PersonType { get; set; }

        public string PersonName { get; set; }

        public string PersonCPFCNPJ { get; set; }

        public string PersonAddress { get; set; }

    }


}
