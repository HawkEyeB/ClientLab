using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto(float rendimento);

    }
}
