using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gyümölcs
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = null;
        MySqlCommand parancs = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                parancs = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll");
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
            gyumolcs_update();
        }
        private void gyumolcs_update()
        {
            listBox1_gyümölcsök.Items.Clear();
            parancs.CommandText = "SELECT id, nev, egysegar, mennyiseg FROM gyumolcsok WHERE 1";
            connection.Open();
            using (MySqlDataReader dr = parancs.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("egysegar"), dr.GetDouble("mennyiseg"));
                    listBox1_gyümölcsök.Items.Add(uj);
                }
            }
        }

        private void be_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2_nev.Text))
            {
                MessageBox.Show("Adjon meg egy gyümölcs nevet!");
                textBox2_nev.Focus();
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Addja meg hány db szeretne!");          
                numericUpDown1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3_egysegar.Text))
            {
                MessageBox.Show("Nem adott meg egységárat!");
                textBox3_egysegar.Focus();
                return;
            }
            parancs.CommandText = "INSERT INTO `gyumolcsok` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES(NULL, @nev, @egysegar, @mennyiseg);";
            parancs.Parameters.Clear();
            parancs.Parameters.AddWithValue("@nev", textBox2_nev.Text);
            parancs.Parameters.AddWithValue("@egysegar", textBox3_egysegar.Text);
            parancs.Parameters.AddWithValue("@mennyiseg", numericUpDown1.Value.ToString());
            try
            {
                if (parancs.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox2_nev.Text = "";                  
                    textBox3_egysegar.Text = "";
                    numericUpDown1.Value = numericUpDown1.Minimum;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            gyumolcs_update();
        }
    }     
}
