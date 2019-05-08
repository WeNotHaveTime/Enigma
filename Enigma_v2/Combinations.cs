using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    static class Combinations
    {
        static public double Calculate_combinations(Settings S)
        {
            double Factorial(int numb)
            {
                double res = 1;
                for (double i = numb; i > 1; i--)
                    res *= i;
                return res;
            }

            int n = S.Alphabet.Length;
            int l = S.Rotors.Count + 1; // +1 тому, що рефлектор теж виконує алгоритм заміни
            int m = S.Plugboard.Count;

            double what_rotors = Factorial(n);
            double order_rotors = Factorial(l);
            double positions_rotors = (double)Math.Pow(n, l);

            double all_rotors = what_rotors * order_rotors * positions_rotors; // Комбінації відповідно до роторів

            double plugboard = 1;
            double expt_zero = Factorial(n - 2 * m) * Factorial(m) * (ulong)Math.Pow(2, m);
            if (expt_zero != 0) plugboard = Factorial(n) / expt_zero; // Кількість комбінацій можливих пар

            return all_rotors * plugboard; // Загальна кількість комбінацій потрібних для перебору, щоб взламати ключ
        }
       
    }
}
