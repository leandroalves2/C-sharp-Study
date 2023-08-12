using System;

namespace _3_exercicioFixacao {
    internal class Quartos {

        public string Nome;
        public string Email;

        public Quartos(string nome, string email){
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
