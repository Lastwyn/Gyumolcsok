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
            connection.Close();
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
        private bool nincsenek_adatok()
        {
            if (string.IsNullOrEmpty(textBox2_nev.Text))
            {
                MessageBox.Show("Adjon meg egy nevet!");
                textBox2_nev.Focus();
                return true;
            }
            if (numericUpDown1.Value > 0)
            {
                MessageBox.Show("Érvénytelen mennyiség!");             
                numericUpDown1.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox3_egysegar.Text))
            {
                MessageBox.Show("Nem adott meg egységárat!");
                textBox3_egysegar.Focus();
                return true;
            }
            return false;
        }
        private void btn_modosit_Click(object sender, EventArgs e)
        {
            if (listBox1_gyümölcsök.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }
            gyumolcs kivalasztottgyumolcs = (gyumolcs)listBox1_gyümölcsök.SelectedItem;
            parancs.CommandText = "UPDATE gyumolcsok SET nev = @nev, egysegar = @egysegar, mennyiseg = @mennyiseg WHERE id = @id";
            parancs.Parameters.Clear();
            parancs.Parameters.AddWithValue("@id", textBox1_id.Text);
            parancs.Parameters.AddWithValue("@nev", textBox2_nev.Text);
            parancs.Parameters.AddWithValue("@egysegar", textBox3_egysegar.Text);
            parancs.Parameters.AddWithValue("@mennyiseg", numericUpDown1.Text);
            connection.Open();
            if (parancs.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres");
                connection.Close();
                textBox1_id.Text = "";
                textBox2_nev.Text = "";
                textBox3_egysegar.Text = "";
                numericUpDown1.Value = numericUpDown1.Minimum;
                gyumolcs_update();
            }
            else
            {
                MessageBox.Show("Az adatok Módosítása sikertelen!");

            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void listBox1_gyümölcsök_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1_gyümölcsök.SelectedIndex < 0)
            {
                return;
            }
            gyumolcs kivalasztottgyumolcs = (gyumolcs)listBox1_gyümölcsök.SelectedItem;
            textBox1_id.Text = kivalasztottgyumolcs.Id.ToString();
            textBox2_nev.Text = kivalasztottgyumolcs.Nev;
            textBox3_egysegar.Text = kivalasztottgyumolcs.Egysegar;
            numericUpDown1.Value = Convert.ToDecimal(kivalasztottgyumolcs.Menniseg);
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            if (listBox1_gyümölcsök.SelectedIndex < 0)
            {
                return;
            }
            parancs.CommandText = "DELETE FROM gyumolcsok WHERE id = @id";
            parancs.Parameters.Clear();
            parancs.Parameters.AddWithValue("@id", textBox1_id.Text);
           
            connection.Open();
            if (parancs.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A törlés sikeres!");
                connection.Close();
                textBox1_id.Text = "";
                textBox2_nev.Text = "";
                textBox3_egysegar.Text = "";
                numericUpDown1.Value = numericUpDown1.Minimum;
                 gyumolcs_update();
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
        }
    }
         
}
