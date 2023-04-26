//Scopo di questa esercitazione è di implementare i metodi di una semplice calcolatrice e di scrivere una classe di test per verificare che funzionino come ci aspettiamo!
//Creare una classe chiamata Calculator avente i seguenti metodi pubblici :
//float Add(float num1, float num2)
//float Subtract(float num1, float num2)
//float Divide(float num1, float num2)
//float Multiply(float numAdd1, float num2)

namespace net_calculator_tester
{
    public static class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

    }
}



