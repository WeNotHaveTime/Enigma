using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Enigma
{
    public partial class F_SettingsManager : Form
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

        public F_SettingsManager()
        {
            InitializeComponent();
        }

        SqlDataReader sqlReader = null;  // ініціалізація 
        Settings setting;


        public async void My_ExecuteNonQueryAsync(SqlCommand command)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            command.Connection = conn;
            await command.ExecuteNonQueryAsync();
            conn.Close();
        } //Виконання команди
        public async void Select_toTable()
        {
            dataGridView1.Rows.Clear();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            await conn.OpenAsync();
            SqlCommand info = new SqlCommand("SELECT Name FROM [Main]", conn);
            try
            {
                sqlReader = await info.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    dataGridView1.Rows.Add(sqlReader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();

            }
        }
        public void DB_to_Settings()
        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string alphabet = "";
            bool sensitivity = false;
            string reflector = "";
            List<string> Plugboard = new List<string>();
            List<string> Rotors = new List<string>();
            List<int> Positions = new List<int>();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand M = new SqlCommand("SELECT * FROM [Main] WHERE [Name] = '" + name + "'", conn);
            SqlCommand R = new SqlCommand("SELECT [Rotor], [Position] FROM [Rotors] WHERE [Name] = '" + name + "'", conn);
            SqlCommand P = new SqlCommand("SELECT [Couple] FROM [Plugboard] WHERE [Name] = '" + name + "'", conn);
            try
            {
                sqlReader = M.ExecuteReader();
                while (sqlReader.Read())
                {
                    alphabet = sqlReader[1].ToString();
                    sensitivity = Convert.ToBoolean(sqlReader[2]);
                    reflector = sqlReader[3].ToString();
                }
                sqlReader.Close();

                sqlReader =  R.ExecuteReader();
                while ( sqlReader.Read())
                {
                    Rotors.Add(sqlReader[0].ToString());
                    Positions.Add(Convert.ToInt32(sqlReader[1]));
                }
                sqlReader.Close();

                sqlReader =  P.ExecuteReader();
                while ( sqlReader.Read())
                {
                    Plugboard.Add(sqlReader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
                setting = new Settings(name, alphabet, sensitivity, Plugboard, Rotors, Positions, reflector);

            }

        }
        public void Insert(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions, List<string> Plugboard)
        {
            SqlCommand addM = new SqlCommand("INSERT INTO [Main] ([Name], [Alphabet], [Sensitivity], [Reflector]) VALUES (@Name, @Alphabet, @Sensitivity, @Reflector)");
            addM.Parameters.AddWithValue("Name", name);
            addM.Parameters.AddWithValue("Alphabet", alphabet);
            addM.Parameters.AddWithValue("Sensitivity", Convert.ToInt16(sensitivity));
            addM.Parameters.AddWithValue("Reflector", reflector);
            My_ExecuteNonQueryAsync(addM);

            for (int i = 0; i < Rotors.Count; i++)
            {
                SqlCommand addR = new SqlCommand("INSERT INTO [Rotors] ([Name], [Rotor], [Position]) VALUES (@Name, @Rotor, @Position)");
                addR.Parameters.AddWithValue("Name", name);
                addR.Parameters.AddWithValue("Rotor", Rotors[i]);
                addR.Parameters.AddWithValue("Position", Positions[i]);
                My_ExecuteNonQueryAsync(addR);
            }
            for (int i = 0; i < Plugboard.Count; i++)
            {
                SqlCommand addP = new SqlCommand("INSERT INTO [Plugboard] ([Name], [Couple]) VALUES (@Name, @Couple)");
                addP.Parameters.AddWithValue("Name", name);
                addP.Parameters.AddWithValue("Couple", Plugboard[i]);
                My_ExecuteNonQueryAsync(addP);
            }

        } // Додавання елементу
        public void Remove(string Name)
        {
            SqlCommand rem = new SqlCommand("DELETE FROM [Main] WHERE Name = '" + Name + "'");
            My_ExecuteNonQueryAsync(rem);
        } //видалення елемента


        private bool NewName()
        {
            bool new_name = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == T_Name.Text)
                {
                    new_name = false;
                }
            }
            return new_name;
        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            if (T_Name.Text != string.Empty)
            {
                if (NewName())
                {
                    F_Stage_1 F = new F_Stage_1(T_Name.Text);
                    F.Show();
                    T_Name.Clear();
                    Hide();
                }
                else MessageBox.Show("Дане ім'я вже існує!");
            }
            else
            {
                MessageBox.Show("Введінь назву, щоб створити налаштування!");
            }
        }
        private void B_Rem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                Remove(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Select();
            }
            else MessageBox.Show("Таблиця пуста!");
            Select_toTable();
        }
        private void B_Choose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                DB_to_Settings();
                var F = Application.OpenForms.OfType<F_Cript>().Single();
                F.Settings = setting;
                F.Show();
                Hide();
                
            }
            else MessageBox.Show("Таблиця пуста!"); 
        }
        
        private void F_SettingsManager_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
            Select_toTable();
        }
        private void B_Exit_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Cript>().Single();
            F.Show();
            Close();
        }

        private void B_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                DB_to_Settings();

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
                    sr.WriteLine("Моя'Enigma' v" + Application.ProductVersion + " Налаштування");
                    for (int i = 0; i < setting.Save_text().Count; i++)
                    {
                        sr.WriteLine(setting.Save_text()[i]);
                    }
                    sr.Flush();
                    sr.Close();
                }
            }
            else MessageBox.Show("Таблиця пуста!");
        }
        private void B_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                string name = "";
                string alphabet = "";
                bool sensitivity = false;
                string reflector = "";
                List<string> Plugboard = new List<string>();
                List<string> Rotors = new List<string>();
                List<int> Positions = new List<int>();


                string text = "";
                int i = 0;
                int j = 0;
                int n = 0;
                do
                {
                    text = sr.ReadLine();

                    if (text.Contains("Назва: "))
                    {
                        name = text.Substring(text.IndexOf("Назва: ") + 7);
                    }
                    if (text.Contains("Алфавіт: "))
                    {
                        alphabet = text.Substring(text.IndexOf("Алфавіт: ") + 9);
                    }
                    if (text.Contains("Регістр: "))
                    {
                        sensitivity = Convert.ToBoolean(text.Substring(text.IndexOf("Регістр: ") + 9));
                    }
                    if (text.Contains("Комутаційна пара" + n + ": "))
                    {
                        Plugboard.Add(text.Substring(text.IndexOf("Комутаційна пара" + n + ": ") + 19));
                        n++;
                    }
                    if (text.Contains("Ротор" + i + ": "))
                    {
                        Rotors.Add(text.Substring(text.IndexOf("Ротор" + i + ": ") + 8));
                        i++;
                    }
                    if (text.Contains("Позиція" + j + ": "))
                    {
                        Positions.Add(Convert.ToInt32(text.Substring(text.IndexOf("Позиція" + j + ": ") + 10)));
                        j++;
                    }
                    if (text.Contains("Рефлектор: "))
                    {
                        reflector = text.Substring(text.IndexOf("Рефлектор: ") + 11);
                    }
                }
                while (!sr.EndOfStream);
                sr.Close();
                try
                {
                    Insert(name, alphabet, sensitivity, reflector, Rotors, Positions, Plugboard);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Select_toTable();
                }
            }
        }

        private void B_Combinations_Click(object sender, EventArgs e)
        {
            DB_to_Settings();
            
            MessageBox.Show(Combinations.Calculate_combinations(setting).ToString(), "Кількість комбінацій");
        }
    }
}
