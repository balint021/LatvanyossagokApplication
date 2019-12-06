using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class LatvanyossagModositasForm : Form
    {
        MySqlConnection conn;
        private int id;
        private string nev;
        private string leiras;
        private int ar;


        public LatvanyossagModositasForm(int id, string nev, string leiras, int ar)
        {
            InitializeComponent();

            this.id = id;
            textBox1.Text = nev;
            textBox2.Text = leiras;
            numericUpDown1.Value = ar;
            try
            {
                conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;Pwd=;");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(numericUpDown1.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
                return; //void metódus futása megszakad return-el
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE latvanyossagok SET nev = @nev, leiras = @leiras, ar = @ar
                                WHERE id = @id";
            cmd.Parameters.AddWithValue("@nev", textBox1.Text);
            cmd.Parameters.AddWithValue("@leiras", textBox2.Text);
            cmd.Parameters.AddWithValue("@ar", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@id", this.id);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sikeres frissítés!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
