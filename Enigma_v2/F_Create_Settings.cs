using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Create_Settings : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        private void CapturModul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        private void Visual_Load_Form()
        {
            Opacity = 0;
            Timer T = new Timer();
            T.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.025) == 1)
                    T.Stop();
            });
            T.Interval = 1;
            T.Start();
        }


        string name;
        public F_Create_Settings(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_SettingsManager>().Single();
            F.Show();
            Close();
        }

        private void F_Creaate_Settings_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }

        private void L_Alphabet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Алфавіт для даної програми - це набір символів які будуть використовуватись під час шифрування." +
                "(Символи не повинні повторюватись) Для роботи алгоритму програми алфавіт повинен містити парну кількість символів!", "Алфавіт");
        }


        private void L_Reflector_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рефлектор являється елементом який реалізує алгоритм заміни попарно і гарантує, що шифрування є інволюційним, тобто шифрування " +
                "та дешифрування являється одиним алгоритм.Наявність рефлектора робить неможливим шифрування літери в саму себе.", "Рефлектор");
        }

        private void L_Rotors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кожен з роторів реалізує простий алгоритм заміни. Позиція ротору реалізує циклічний здвиг послідовності. " +
                "Перед шифруванням кожної літери відбувається інкремент ротору. Ротори імітують годинниковий механізм, тобто після проходження " +
                "повного циклу ротору відбувається інкремент наступного. ", "Ротори");
        }

        private void L_Plugboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Комутаційна панель використовується як додатковий спосіб задання пари заміни.Заміна в ході роботи програми буде використовуватись двічі.", "Комутаційна панель");
        }

        private void B_Custom_Click(object sender, EventArgs e)
        {
            var F = new F_Stage_1(name);
            F.Show();
            Close();
        }

        private void C_Alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var C = (ComboBox)sender;
            Num_Plugboard.Maximum = C.Text.Length / 2;
        }

        void Generate_Rotors(string alphabet, int number, ref List<string> Rotors, ref List<int> Positions)
        {
            int c = alphabet.Length;
            Random random = new Random();
            for (int x = 0; x < number; x++)
            {
                string rotor = "";
                for (int i = 0; i < c; i++)
                {
                    char j = alphabet[random.Next(0, alphabet.Length)];
                    while (rotor.Contains(j))
                    {
                        j = alphabet[random.Next(0, alphabet.Length)];
                    }
                    rotor += j;
                }
                Rotors.Add(rotor);
                Positions.Add(random.Next(0,alphabet.Length - 1));
            }
        } // Генерація випадкових роторів/рефлекторів
        string Generate_Reflector(string alphabet)
        {
            int c = alphabet.Length;
            Random random = new Random();

            string reflector = "";
            for (int i = 0; i < c; i++)
            {
                char j = alphabet[random.Next(0, alphabet.Length)];
                while (reflector.Contains(j))
                {
                    j = alphabet[random.Next(0, alphabet.Length)];
                }
                reflector += j;
            }
            return reflector;
        } // Генерація випадкових роторів/рефлекторів

        void Generarate_Plugboards(string alphabet, int number, ref List<string> Plugboards)
        {
            int c = alphabet.Length;
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                char ch1 = alphabet[random.Next(0, alphabet.Length)];
                char ch2 = alphabet[random.Next(0, alphabet.Length)];

                alphabet.Remove(alphabet.IndexOf(ch1), 1);
                if(ch1 != ch2) alphabet.Remove(alphabet.IndexOf(ch2), 1);

                Plugboards.Add(ch1.ToString() + ch2.ToString());
            }
        }
        private void B_Ok_Click(object sender, EventArgs e)
        {
            string alphabet = C_Alphabet.SelectedText;
            bool sensitivity = false;
            string reflector;
            List<string> rotors = new List<string>();
            List<int> positions = new List<int>();
            List<string> plugboard = new List<string>();

        }
    }
}
