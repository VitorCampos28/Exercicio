using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime birthDay { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            this.email = email;
            this.birthDay = birthDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (" + birthDay + ")");
            sb.Append(" - ");
            sb.Append(email);
            return sb.ToString();
        }
    }
}
