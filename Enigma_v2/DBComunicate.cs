using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public static class DBComunicate
    {
        static private SqlDataReader sqlReader = null;
        static private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД

        private static void My_ExecuteNonQuery(SqlCommand command)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        } //Виконання команди
        static public void Select_toTable(ref DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand info = new SqlCommand("SELECT Name FROM [Main]", conn);
            try
            {
                sqlReader =  info.ExecuteReader();
                while ( sqlReader.Read())
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
        static public void DB_to_Settings(string name, ref Settings setting)
        {
            string alphabet = "";
            bool sensitivity = false;
            string reflector = "";
            List<string> Plugboard = new List<string>();
            List<string> Rotors = new List<string>();
            List<int> Positions = new List<int>();
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

                sqlReader = R.ExecuteReader();
                while (sqlReader.Read())
                {
                    Rotors.Add(sqlReader[0].ToString());
                    Positions.Add(Convert.ToInt32(sqlReader[1]));
                }
                sqlReader.Close();

                sqlReader = P.ExecuteReader();
                while (sqlReader.Read())
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
        static public void Insert(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions, List<string> Plugboard)
        {
            SqlCommand addM = new SqlCommand("INSERT INTO [Main] ([Name], [Alphabet], [Sensitivity], [Reflector]) VALUES (N'" + name + "', @Alphabet, @Sensitivity, @Reflector)");
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
                    if (i == 0) addR.CommandText += " VALUES (N'" + name + "', '" + Rotors[i] + "', " + Positions[i] + ")";
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
                    if (i == 0) addP.CommandText += " VALUES (N'" + name + "', '" + Plugboard[i] + "')";
                    else addP.CommandText += ", ('" + name + "', '" + Plugboard[i] + "')";
                }
                My_ExecuteNonQuery(addP);
            }

        } // Додавання елементу
        static public void Remove(string Name)
        {
            SqlCommand rem = new SqlCommand("DELETE FROM [Main] WHERE Name = '" + Name + "'");
            My_ExecuteNonQuery(rem);
        } //видалення елемента


    }
}
