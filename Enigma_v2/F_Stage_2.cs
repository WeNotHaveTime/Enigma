using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Stage_2 : Form
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
            T.Tick += new EventHandler((sender1, e1) =>
            {
                if ((Opacity += 0.025) == 1)
                    T.Stop();
            });
            T.Interval = 1;
            T.Start();

        }

        ToolTip T = new ToolTip();
        string name;
        string alphabet;
        bool sensitivity;

        public F_Stage_2(string name, string alphabet, bool sensitivity)
        {
            InitializeComponent();
            this.name = name;
            this.alphabet = alphabet;
            this.sensitivity = sensitivity;
            L_Alph_Reflect.Text = alphabet;
            T.SetToolTip(this.L_Alph_Reflect, L_Alph_Reflect.Text);

            if (!sensitivity) T_Reflector.CharacterCasing = CharacterCasing.Upper;
        }
        private void B_Rand_Reflector_Click(object sender, EventArgs e)
        {
            string Generate()
        {
            int c = alphabet.Length;
            Random random = new Random();

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
            return rotor;
        } // Генерація випадкових роторів/рефлекторів
            string reflect = Generate(); // Генерування
            T_Reflector.Text = reflect;
        }
        private void T_Reflector_TextChanged(object sender, EventArgs e)
        {
            void TextBoxEntry(TextBox TB, Label L_Alpha)
        {
            L_Alpha.Text = alphabet;

            string tx = TB.Text;
            for (int i = 0; i < tx.Length; i++)
            {
                if (L_Alpha.Text.Contains(tx[i])) L_Alpha.Text = L_Alpha.Text.Remove(L_Alpha.Text.IndexOf(tx[i]), 1);
                else TB.Text = tx.Remove(tx.IndexOf(tx[i]), 1);
            }

            TB.SelectionStart = TB.Text.Length;
            T.SetToolTip(L_Alph_Reflect, L_Alph_Reflect.Text);
        }  // Загальна ф-ція заповнення полів відповідно до алфавіту
            TextBoxEntry(T_Reflector, L_Alph_Reflect);
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            if (T_Reflector.Text.Length != 0 )
            {
                if (alphabet.Length == T_Reflector.Text.Length)
                {
                    F_Stage_3 F = new F_Stage_3(name, alphabet, sensitivity, T_Reflector.Text);
                    F.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Будь ласка введіть всі символи!");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка введіть дані!");
            }
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Stage_1>().Single();
            F.Show();
            Close();
        }
        private void F_Stage_2_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }
    }
}
