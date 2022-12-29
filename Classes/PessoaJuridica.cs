using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;
using System.Text.RegularExpressions;

namespace ClientLab.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica 
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            // 55.664.305/0001-90 - 18
            // 55664305000190 - 14


            if (Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
            {
                //valida se tem o mil contra 0001
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }

            }

            return false;
        }
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return (rendimento - (rendimento / 100) * 6);
            }
            else if (rendimento <= 10000)
            {
                return (rendimento - (rendimento / 100) * 8);
            }
            else
            {
                return (rendimento - (rendimento / 100) * 10);
            }
        }
    }
}