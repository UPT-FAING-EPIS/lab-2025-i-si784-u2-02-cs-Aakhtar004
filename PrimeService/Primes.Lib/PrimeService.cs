namespace Primes.Lib
{
    /// <summary>
    /// Servicio para determinar si un número es primo.
    /// </summary>
    public class PrimeService
    {
        /// <summary>
        /// Determina si un número es primo.
        /// </summary>
        /// <param name="candidate">El número a evaluar.</param>
        /// <returns>True si el número es primo, de lo contrario False.</returns>
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) return false;
            
            // Verificar si el número es divisible por algún entero desde 2
            // hasta la raíz cuadrada del número
            for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
