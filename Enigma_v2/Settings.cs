using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Settings
    {
        public Settings(string Name, string Alphabet, bool Sensitivity,List<string> Plugboard, List<string> Rotors, List<int> Positions, string Reflector)
        {
            this.Name = Name;
            this.Alphabet = Alphabet;
            this.Sensitivity = Sensitivity;
            this.Plugboard = Plugboard;
            this.Rotors = Rotors;
            this.Positions = Positions;
            this.Reflector = Reflector;
        }

        public string Name { get; private set; }
        public string Alphabet { get; private set; }
        public bool Sensitivity { get; private set; }
        public List<string> Plugboard { get; private set; } = new List<string>();
        public List<string> Rotors { get; private set; } = new List<string>();
        public List<int> Positions { get; set; } = new List<int>();
        public string Reflector { get; private set; } = string.Empty;

        public List<string> Save_text()
        {
            List<string> save_text = new List<string>();
            save_text.Add("Назва: " + Name);
            save_text.Add("Алфавіт: " + Alphabet);
            save_text.Add("Регістр: " + Sensitivity);

            for (int i = 0; i < Plugboard.Count; i++)
            {
                save_text.Add("Комутаційна пара" + i + ": " + Plugboard[i]);
            }

            for (int i = 0; i < Positions.Count; i++)
            {
                save_text.Add("Ротор" + i + ": " + Rotors[i]);
                save_text.Add("Позиція" + i + ": " + Positions[i]);
            }

            save_text.Add("Рефлектор: " + Reflector);

            return save_text;
        }
    }
}
