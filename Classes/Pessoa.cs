using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class Pessoa : IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;

        public float Rendimento;

        public float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }

}