using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Cript
    {
        
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ";
        private int lenth = alphabet.Length - 1;

        public string Input { get; private set; }
        public string Output { get; private set; }

        private List<string> Plugboard  = new List<string>();
        private List<string> _Rotors  = new List<string>();
        private List<int> Positions  = new List<int>();
        private string Reflector  = string.Empty;


        public Cript(string tx, Settings S)
        {
            Input = tx;

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
                if (Positions[n] == lenth)
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
            if (!alphabet.Contains(letter)) { return letter; }// фільтр

            List<string> Rotor_String()
            {
                List<string> R = new List<string>();

                for (int i = 0; i < _Rotors.Count; i++)
                {
                    string S = _Rotors[i];
                    R.Add(S);
                }
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
            } //Зміна запису ротору перед шифруванням (фактична зміна ротора)

            List<string> Rotors = new List<string>();
            Rotors = Rotor_String();
            //
            // Шифр = Панель * Ротори * Pефлектор * Pотори^-1 * Панель
            //

            // Етап 1 - Комутаційна панель
            void F_Plugboard(){
                for (int i = 0; i < Plugboard.Count; i++)
                {
                    if (letter == Plugboard[i].ElementAt(0))
                    {
                        letter = Plugboard[i].ElementAt(1);

                    }
                    else if (letter == Plugboard[i].ElementAt(1))
                    {
                        letter = Plugboard[i].ElementAt(0);
                    }
                }
            }

            // Етап 2 - Пошук позиції в нерухомому вхідному колесі
            int position = 0;
            void find_position()
            {
                for (int i = 0; i < alphabet.Count(); i++)
                {
                    if (letter == alphabet[i])
                    {
                        position = i;
                    }
                }
            } // створення ллокальної функції, оскільки процедука використовується неодноразово
            find_position();

            // Етап 3 - ротори - зростання. (0,1,2,3,4....)
            {
                for (int i = 0; i < Rotors.Count(); i++)
                {
                    string rotor = Rotors[i]; // ротор
                    // Спочатку замінюємо, потім ідентифікуємо літеру (на якій позиції знаходиться літера відносно 0)
                    letter = rotor.ElementAt(position);
                    find_position();
                }
            }
           
            // Етап 4 Рефлектор (рефлектор є повністю симетричним)
            {
                for (int i = 0; i < Reflector.Count(); i++)
                {
                    if (letter == Reflector[i])
                    {
                        position = i;
                    }
                }
                position = lenth - position;
                letter = Reflector.ElementAt(position);
            }
           
            // Етап 5 - ротори - звортній рух. (....3,2,1,0)
            {
                for (int i = Rotors.Count() - 1; i >= 0; i--)
                {
                    string rotor = Rotors[i]; // ротор
                    
                    // Ідентифікуємо літеру в роторі, потім замінюємо

                    for (int j = 0; j < Rotors[i].Count(); j++)
                    {
                        if (letter == rotor[j])
                        {
                            position = j;
                        }
                    }
                    letter = alphabet[position];
                }
            }
            
            // Етап 6 Вхідне колесо
            {
                find_position();
                letter = alphabet[position];
            }

            // Етап 7 Комутаційна панель
            F_Plugboard();

            return letter;
        } // Шифрування символу
    }
}
