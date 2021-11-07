using System;

namespace ValidarCPFeCPNJ
{
    class Program
    {
        static void Main(string[] args)
        {
            CPFCNPJ.IMain checkCPFCNPJ = new CPFCNPJ.Main();
            var resultCNPJ = checkCPFCNPJ.IsValidCPFCNPJ("53645180000150");

            Console.WriteLine(resultCNPJ);

            var resultCPF = checkCPFCNPJ.IsValidCPFCNPJ("09033909922");
            Console.WriteLine(resultCPF);
        }
    }
}
