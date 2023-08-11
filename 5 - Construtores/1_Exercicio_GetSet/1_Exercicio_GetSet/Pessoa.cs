using System;
using System.Globalization;


namespace _1_Exercicio_GetSet {
    internal class Pessoa {      
        
        CultureInfo ci = CultureInfo.InvariantCulture;

        private string _nome;


        public string GetNome() {
            return this._nome;
        }
        public void SetNome(string nome) {
            this._nome = nome;
        }
 

        private double _altura;        
        public double GetAltura() {
            return this._altura;
        }
        public void SetAltura(double altura) {
            this._altura = altura; 
        }

        private int _nascimento;        
        public int GetNascimento() { 
            return this._nascimento; 
        }
        public void SetNascimento(int nascimento) {
            this._nascimento = nascimento;
        }

        public int IdadePessoa() {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this._nascimento;
            return idade;
        }

        public override string ToString() {
            return "Os dados inseridos foram: Nome: " + this._nome + ", da altura: " + this._altura.ToString("F2", ci) 
                + ", que nasceu no ano de: " + _nascimento + ", tem hoje a idade de: " + IdadePessoa();
        }
    }
}
