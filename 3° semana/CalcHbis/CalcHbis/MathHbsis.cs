using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcHbis
{
    public class MathHbsis
    {
        /// <summary>
        /// Função que retorna a area de um retangulo.
        /// </summary>
        /// <param name="pBase">Valor do comprimento da base</param>
        /// <param name="pAltura">Valor do comprimento da altura</param>
        /// <returns></returns>
        public double RetornaAreaRetangulo(double pBase, double pAltura)
        {
            return pBase * pAltura;
        }
        /// <summary>
        /// Função que retorna a area de um triangulo equilatero.
        /// </summary>
        /// <param name="pBase">Valor do comprimento da base</param>
        /// <param name="pAltura">Valor do comprimento da altura</param>
        /// <returns></returns>
        public double RetornaAreaTrianguloEquilatero(double pBase, double pAltura)
        {
            return (pBase * pAltura)/2;
        }
        /// <summary>
        /// Função que retorna o raio de um circulo através do valor de área.
        /// </summary>
        /// <param name="pArea">Valor de area do circulo</param>
        /// <returns></returns>
        public double RetornaRaioDeUmCirculo(double pArea)
        {           
            return Math.Sqrt(pArea / 3.14);
        }
        /// <summary>
        /// Retorna a soma de dois numeros
        /// </summary>
        /// <param name="pNumero1">valor do primeiro numro</param>
        /// <param name="pNumero2">valor do segundo  numero que sera somado ao primeiro</param>
        /// <returns></returns>
        public double RetornaSoma(double pNumero1, double pNumero2)
        {
            return pNumero1 + pNumero2;
        }
        /// <summary>
        /// Retorna a subtração entre dois numeros
        /// </summary>
        /// <param name="pNumero1">Primeiro valor</param>
        /// <param name="pNumero2">Segundo valor, este será subtraido do primeiro</param>
        /// <returns></returns>
        public double RetornaSubtrcao(double pNumero1, double pNumero2)
        {
            return pNumero1 - pNumero2;
        }
        /// <summary>
        /// Retorna a multiplicação entre dois numeros
        /// </summary>
        /// <param name="pNumero1">Primeiro valor</param>
        /// <param name="pNumero2">Segundo valor</param>
        /// <returns></returns>
        public double RetornaMultiplicacao(double pNumero1, double pNumero2)
        {
            return pNumero1 * pNumero2;
        }
        /// <summary>
        /// Retorna a divisão entre dois numeros
        /// </summary>
        /// <param name="pNumero1">primeiro valor que sera dividido</param>
        /// <param name="pNumero2">segundo valor é o radical da divisão</param>
        /// <returns></returns>
        public double RetornaDivisao(double pNumero1, double pNumero2)
        {
            return pNumero1 / pNumero2;
        }
    }
}
