using System;

namespace AulaListas
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }
        public string Vencimento { get; set; }
        public string cvv { get; set; }

        public Cartao(){

        }

        public Cartao(string _titular, string _numero, string _bandeira, string _vencimento, string _cvv){
            this.Bandeira = _bandeira;
            this.cvv = _cvv;
            this.Numero = _numero;
            this.Titular = _titular;
            this.Vencimento = _vencimento;
        }
    }
}