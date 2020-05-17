using System;

namespace Ex010
{
    class Dados
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Dados(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return
            Name
            + ", "
            + Email;
        }
    }
}
