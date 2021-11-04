using CursoDesignPatterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
           
           double icms = new ICMS().Calcula(orcamento);
           Console.WriteLine(icms);
        
        }
        


    }
}
