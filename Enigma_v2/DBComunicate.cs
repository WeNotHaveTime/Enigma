using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enigma
{
    public static class DBComunicate
    {
        static private SqlDataReader sqlReader = null;
        static private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSettings.mdf;"; // адреса БД

        private static void My_ExecuteNonQuery(SqlCommand command)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        } //Виконання команди
        static public async void Select_toTable(this DataGridView DG)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand info = new SqlCommand("SELECT Name FROM [Main]", conn);
            try
            {
                sqlReader = await info.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    DG.Rows.Add(sqlReader[0].ToString());
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

            SqlCommand M = new SqlCommand("SELECT * FROM [Main] WHERE [Name] = N'" + name + "'", conn);
            SqlCommand R = new SqlCommand("SELECT [Rotor], [Position] FROM [Rotors] WHERE [Name] = N'" + name + "'", conn);
            SqlCommand P = new SqlCommand("SELECT [Couple] FROM [Plugboard] WHERE [Name] = N'" + name + "'", conn);
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
            SqlCommand addM = new SqlCommand("INSERT INTO [Main] ([Name], [Alphabet], [Sensitivity], [Reflector]) VALUES (N'" + name + "',N'" + alphabet + "', '" + sensitivity.ToString() + "',N'" + reflector + "')");
            My_ExecuteNonQuery(addM);

            if (Rotors.Count != 0)
            {
                SqlCommand addR = new SqlCommand();
                addR.CommandText = "INSERT INTO [Rotors] ([Name], [Rotor], [Position])";
                for (int i = 0; i < Rotors.Count; i++)
                {
                    if (i == 0) addR.CommandText += " VALUES (N'" + name + "', N'" + Rotors[i] + "', " + Positions[i] + ")";
                    else addR.CommandText += ", (N'" + name + "', N'" + Rotors[i] + "', " + Positions[i] + ")";
                }
                My_ExecuteNonQuery(addR);
            }

            if (Plugboard.Count != 0)
            {
                SqlCommand addP = new SqlCommand();
                addP.CommandText = "INSERT INTO [Plugboard] ([Name], [Couple])";
                for (int i = 0; i < Plugboard.Count; i++)
                {
                    if (i == 0) addP.CommandText += " VALUES (N'" + name + "', N'" + Plugboard[i] + "')";
                    else addP.CommandText += ", (N'" + name + "', N'" + Plugboard[i] + "')";
                }
                My_ExecuteNonQuery(addP);
            }

        } // Додавання елементу
        static public void Remove(string Name)
        {
            SqlCommand rem = new SqlCommand("DELETE FROM [Main] WHERE Name = N'" + Name + "'");
            My_ExecuteNonQuery(rem);
        } //видалення елемента


    }
}
