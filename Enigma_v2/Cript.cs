using System.Collections.Generic;
using System.Linq;

namespace Enigma
{
    class Cript
    {

        private string alphabet;

        public string Input { get; private set; }
        public string Output { get; private set; }

        private List<string> Plugboard = new List<string>();
        private List<string> _Rotors = new List<string>();
        private List<int> Positions = new List<int>();
        private string Reflector = string.Empty;

        public Cript(string tx, Settings S)
        {
            if (S.Sensitivity)
            {
                Input = tx;
            }
            else Input = tx.ToUpper();

            alphabet = S.Alphabet;

            Plugboard.AddRange(S.Plugboard);
            _Rotors.AddRange(S.Rotors);
            Positions.AddRange(S.Positions);
            Reflector = S.Reflector;

            for (int i = 0; i < tx.Length; i++)
            {
                Increment_Rotor();
                Output += Cript_letter(Input[i]);
            }
        } // Шифрування


        private void Increment_Rotor()
        {

            int count = Positions.Count;

            for (int n = 0; n < count; n++)
            {
                if (Positions[n] == alphabet.Length - 1)
                {
                    Positions[n] = 0;
                }
                else
                {
                    Positions[n]++;
                    break;
                }
            }
        } // Інкримент ротору (знач. поз.)

        private char Cript_letter(char letter)
        {
            if (!alphabet.Contains(letter)) return letter; // фільтр

            List<string> Rotor_String()
            {
                List<string> R = new List<string>();
                R.AddRange(_Rotors);

                string rotor_inc = "";
                for (int i = 0; i < _Rotors.Count(); i++)
                {
                    for (int j = 0; j < Positions[i]; j++)
                    {
                        rotor_inc = R[i].Substring(1) + R[i].ElementAt(0);
                        R[i] = rotor_inc;
                    }
                }
                return R;
            } //Впровадження позицій

            List<string> Rotors = new List<string>(); ;
            Rotors.AddRange(Rotor_String());
            //
            // Шифр = Панель * Ротори * Pефлектор * Pотори^-1 * Панель
            //

            // Етап 1 - Комутаційна панель
            void Func_Plugboard()
            {
                foreach (string pl in Plugboard)
                {
                    if (pl[0] == letter)
                    {
                        letter = pl[1];
                        break;
                    }
                    if (pl[1] == letter)
                    {
                        letter = pl[0];
                        break;
                    }
                }
            }
            Func_Plugboard();
            // Етап 2 - Пошук позиції в нерухомому вхідному колесі
            int position = alphabet.IndexOf(letter);


            // Етап 3 - ротори - зростання. (0,1,2,3,4....)
            {
                for (int i = 0; i < Rotors.Count(); i++)
                {
                    string rotor = Rotors[i]; // ротор
                    // Спочатку замінюємо, потім ідентифікуємо літеру (на якій позиції знаходиться літера відносно 0)
                    letter = rotor.ElementAt(position);
                    position = alphabet.IndexOf(letter);
                }
            }

            // Етап 4 Рефлектор (рефлектор є повністю симетричним)
            {
                position = Reflector.IndexOf(letter);
                position = (alphabet.Length - 1) - position;
                letter = Reflector.ElementAt(position);
            }
            // Етап 5 - ротори - звортній рух. (....3,2,1,0)
            {
                for (int i = Rotors.Count() - 1; i >= 0; i--)
                {
                    string rotor = Rotors[i]; // ротор

                    // Ідентифікуємо літеру в роторі, потім замінюємо
                    position = rotor.IndexOf(letter);

                    letter = alphabet[position];
                }
            }

            // Етап 6 Вхідне колесо
            {
                position = alphabet.IndexOf(letter);
                letter = alphabet[position];
            }
            // Етап 7 Комутаційна панель
            Func_Plugboard();
            return letter;
        } // Шифрування символу
    }
}
