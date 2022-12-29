using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {

            if (Regex.IsMatch(cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)"))
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj18 = cnpj.Substring(11, 4);
                    if (subStringCnpj18 == "0001")
                    {
                        return true;
                    }
                    return false;
                }
                if (cnpj.Substring(8, 4) == "0001")
                {
                    return true;
                }
            }

            return false;
        }
    }
}