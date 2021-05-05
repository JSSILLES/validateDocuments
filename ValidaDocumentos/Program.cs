using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "37524919816";

            ValidaDocumentoUtil valida = new ValidaDocumentoUtil();

            var retorno = valida.ValidaCPF(cpf);

            Console.WriteLine(retorno);

            Console.ReadKey();

        }
    }
}
