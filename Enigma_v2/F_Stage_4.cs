using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enigma
{
    public partial class F_Stage_4 : Form
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

        public void My_ExecuteNonQuery(SqlCommand command)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        } //Виконання команди
        public void Insert(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions, List<string> Plugboard)
        {
            SqlCommand addM = new SqlCommand("INSERT INTO [Main] ([Name], [Alphabet], [Sensitivity], [Reflector]) VALUES (N'"+ name +"', @Alphabet, @Sensitivity, @Reflector)");
            //addM.Parameters.AddWithValue("Name", name);
            addM.Parameters.AddWithValue("Alphabet", alphabet);
            addM.Parameters.AddWithValue("Sensitivity", Convert.ToInt16(sensitivity));
            addM.Parameters.AddWithValue("Reflector", reflector);
            My_ExecuteNonQuery(addM);

            if (Rotors.Count != 0)
            {
                SqlCommand addR = new SqlCommand();
                addR.CommandText = "INSERT INTO [Rotors] ([Name], [Rotor], [Position])";
                for (int i = 0; i < Rotors.Count; i++)
                {
                    if(i == 0) addR.CommandText += " VALUES (N'"+ name +"', '"+ Rotors[i] +"', "+ Positions[i] + ")";
                    else addR.CommandText += ", ('" + name + "', '" + Rotors[i] + "', " + Positions[i] + ")";
                }
                My_ExecuteNonQuery(addR);
            }

            if (Plugboard.Count != 0)
            {
                SqlCommand addP = new SqlCommand();
                addP.CommandText = "INSERT INTO [Plugboard] ([Name], [Couple])";
                for (int i = 0; i < Plugboard.Count; i++)
                {
                    if (i == 0) addP.CommandText += " VALUES (N'"+ name +"', '" +  Plugboard[i]+"')";
                    else addP.CommandText += ", ('" + name + "', '" + Plugboard[i] + "')";
                }
                My_ExecuteNonQuery(addP);
            }

        } // Додавання елементу

        ToolTip T = new ToolTip();
        string name;
        string alphabet;
        bool sensitivity;
        string reflector;
        List<string> Rotors = new List<string>();
        List<int> Positions = new List<int>();

        public F_Stage_4(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions)
        {
            InitializeComponent();
            this.name = name;
            this.alphabet = alphabet;
            this.sensitivity = sensitivity;
            L_Alpha_K.Text = alphabet;
            T.SetToolTip(this.L_Alpha_K, L_Alpha_K.Text);
            this.reflector = reflector;
            this.Rotors.AddRange(Rotors);
            this.Positions.AddRange(Positions);
            if (!sensitivity)
            {
                T_K1.CharacterCasing = CharacterCasing.Upper;
                T_K2.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void Remove_Ch()
        {
            L_Alpha_K.Text = alphabet;

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                L_Alpha_K.Text = L_Alpha_K.Text.Remove(L_Alpha_K.Text.IndexOf(dataGridView2.Rows[i].Cells[0].Value.ToString()[0]), 1);
                L_Alpha_K.Text = L_Alpha_K.Text.Remove(L_Alpha_K.Text.IndexOf(dataGridView2.Rows[i].Cells[0].Value.ToString()[1]), 1);
            }
            T.SetToolTip(L_Alpha_K, L_Alpha_K.Text);
        }

        private void T_K1_TextChanged(object sender, EventArgs e)
        {
            if (T_K1.Text == "")
                return;
            if (L_Alpha_K.Text.Contains(T_K1.Text))
                T_K2.Focus();
            if (L_Alpha_K.Text.Contains(T_K1.Text) && L_Alpha_K.Text.Contains(T_K2.Text) && !string.IsNullOrEmpty(T_K1.Text) && !string.IsNullOrEmpty(T_K2.Text) && T_K1.Text != T_K2.Text)
            {
                dataGridView2.Rows.Add(T_K1.Text + T_K2.Text);
                T_K1.Clear();
                T_K2.Clear();
                Remove_Ch();
            }
        }
        private void T_K2_TextChanged(object sender, EventArgs e)
        {
            if (T_K2.Text == "")
                return;
            if (L_Alpha_K.Text.Contains(T_K2.Text))
                T_K1.Focus();
            if (L_Alpha_K.Text.Contains(T_K1.Text) && L_Alpha_K.Text.Contains(T_K2.Text) && !string.IsNullOrEmpty(T_K1.Text) && !string.IsNullOrEmpty(T_K2.Text) && T_K1.Text != T_K2.Text)
            {
                dataGridView2.Rows.Add(T_K1.Text + T_K2.Text);
                T_K1.Clear();
                T_K2.Clear();
                Remove_Ch();
            }
        }
        private void B_Remove_Couple_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount != 0)
            {
                string tx = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                Remove_Ch();
            }
            else
            {
                MessageBox.Show("Ви не додали жодної комутаційної пари!");
            }

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            
            List<string> Plugboard = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                Plugboard.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            Insert(name, alphabet, sensitivity, reflector, Rotors, Positions, Plugboard);
            Application.OpenForms.OfType<F_SettingsManager>().First().Close();
            Application.OpenForms.OfType<F_Stage_1>().First().Close();
            Application.OpenForms.OfType<F_Stage_2>().First().Close();
            Application.OpenForms.OfType<F_Stage_3>().First().Close();
            var F = new F_SettingsManager();
            F.Show();
            Close();
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Stage_3>().Single();
            F.Show();
            Close();
        }
        private void F_Stage_4_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }

        void Generarate_Plugboards(ref string alphabet, int number, ref List<string> Plugboards)
        {
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                char ch1 = alphabet[random.Next(0, alphabet.Length)];
                alphabet = alphabet.Remove(alphabet.IndexOf(ch1), 1);
                char ch2 = alphabet[random.Next(0, alphabet.Length)];
                alphabet = alphabet.Remove(alphabet.IndexOf(ch2), 1);
                Plugboards.Add(ch1.ToString() + ch2.ToString());
            }
        }
        private void B_Rand_Click(object sender, EventArgs e)
        {
            List<string> Plugboards = new List<string>();
            string tx = L_Alpha_K.Text;
            Generarate_Plugboards(ref tx, (int)Num_Plugboard.Value, ref Plugboards);
            L_Alpha_K.Text = tx;

            for (int i = 0; i < Plugboards.Count; i++)
            {
                dataGridView2.Rows.Add(Plugboards[i]);
            }
            Remove_Ch();
        }

        private void L_Alpha_K_TextChanged(object sender, EventArgs e)
        {
            Num_Plugboard.Maximum = L_Alpha_K.Text.Length / 2;
        }
    }
}
