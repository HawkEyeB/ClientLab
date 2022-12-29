using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        public bool ValidarDataNasc(string dataNasc)
        {
            DateTime dataConvertida; //tipo nativo que retorna uma data

            if (DateTime.TryParse(dataNasc, out dataConvertida)) // converte date (string) em booleano
            {
                //Console.WriteLine($"String convertida em DateTime: {dataConvertida}");
                DateTime dataAtual = DateTime.Today; // retorna a data do dia atual
                double anos = (dataAtual - dataConvertida).TotalDays / 365; // retorna quantos anos a pessoa tem (retorna um numero real)
                // Console.WriteLine($"Anos: {anos}");
                if (anos >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }
    }
}