using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Stage_3 : Form
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
        string reflector;

        public F_Stage_3(string name, string alphabet, bool sensitivity, string reflector)
        {
            InitializeComponent();
            this.name = name;
            this.alphabet = alphabet;
            this.sensitivity = sensitivity;
            L_Alpha_Rotor.Text = alphabet;
            T.SetToolTip(this.L_Alpha_Rotor, L_Alpha_Rotor.Text);
            this.reflector = reflector;
            Num_Ring.Minimum = 0;
            Num_Ring.Maximum = alphabet.Length - 1;
            if (!sensitivity) T_New_Rotor.CharacterCasing = CharacterCasing.Upper;
        }

        private void B_Add_Rotor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 100)
            {
                MessageBox.Show("Встановлене обмеження. Максимальна кількість роторів -> 100.");
                return;
            }

            if (T_New_Rotor.Text.Length != alphabet.Length)
            {
                MessageBox.Show("Будь ласка заповніть поле для введення повністю!");
            }
            else
            {
                string rotor = T_New_Rotor.Text;
                dataGridView1.Rows.Add(rotor, 0);
                T_New_Rotor.Clear();
            }

        }
        private void T_New_Rotor_TextChanged(object sender, EventArgs e)
        {
            L_Alpha_Rotor.Text = alphabet;

            string tx = T_New_Rotor.Text;
            for (int i = 0; i < tx.Length; i++)
            {
                if (L_Alpha_Rotor.Text.Contains(tx[i])) L_Alpha_Rotor.Text = L_Alpha_Rotor.Text.Remove(L_Alpha_Rotor.Text.IndexOf(tx[i]), 1);
                else T_New_Rotor.Text = tx.Remove(tx.IndexOf(tx[i]), 1);
            }

            T_New_Rotor.SelectionStart = T_New_Rotor.Text.Length;
            T.SetToolTip(L_Alpha_Rotor, L_Alpha_Rotor.Text);
        }

        private void Generate_Rotors(string alphabet, int number, ref List<string> Rotors, ref List<int> Positions)
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
                Positions.Add(random.Next(0, alphabet.Length - 1));
            }
        } // Генерація випадкових роторів
        private void B_Rand_Rotor_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.RowCount;
            int num = (int)Num_Rotors.Value;

            if (count + num > 100)
            {
                MessageBox.Show("Встановлене обмеження. Максимальна кількість роторів -> 100.");
                return;
            }
            List<string> Rotors = new List<string>();
            List<int> Positions = new List<int>();

            Generate_Rotors(alphabet, num, ref Rotors, ref Positions);
            for (int i = 0; i < Rotors.Count; i++)
            {
                dataGridView1.Rows.Add(Rotors[i], Positions[i]);
            }

        }
        private void B_Rem_Rotor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else MessageBox.Show("Ви не додали жодного ротору!");

        }
        private void B_Up_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index == 0) return;
            int index = dataGridView1.SelectedRows[0].Index;
            var r = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(r);
            dataGridView1.Rows.Insert(index - 1, r);

        }
        private void B_Down_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index == dataGridView1.RowCount - 1) return;
            int index = dataGridView1.SelectedRows[0].Index;
            var r = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(r);
            dataGridView1.Rows.Insert(index + 1, r);

        }
        private void Num_Ring_ValueChanged(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(Num_Ring.Value);
            int index = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[index].Cells[1].Value = pos;
        }
        private void B_Reset_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index != -1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[index].Cells[1].Value = 0;

            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть ротор!");
            }

        }
        private void B_All_Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = 0;
            }
        }
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            T_New_Rotor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Num_Ring.Value = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
        } // Допомога в редагуванні

        private void B_Next_Click(object sender, EventArgs e)
        {
            List<string> Rotors = new List<string>();
            List<int> Pos = new List<int>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Rotors.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Pos.Add((int)dataGridView1.Rows[i].Cells[1].Value);
            }

            F_Stage_4 F = new F_Stage_4(name, alphabet, sensitivity, reflector, Rotors, Pos);
            F.Show();
            Hide();
        }
        private void B_Back_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Stage_2>().Single();
            F.Show();
            Close();
        }
        private void F_Stage_3_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            L_Num_Rotors.Text = dataGridView1.RowCount.ToString();
        }
        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            L_Num_Rotors.Text = dataGridView1.RowCount.ToString();
        }
    }
}
