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
    public partial class VarosModositasForm : Form
    {

        MySqlConnection conn;
        private int varosId;
        private string varosNev;
        private int varosLakossag;

        public VarosModositasForm(int id, string varosNev, int varosLak)
        {
            InitializeComponent();

            this.varosId = id;
            this.varosNev = varosNev;
            this.varosLakossag = varosLak;

            txtNev.Text = varosNev;
            numLak.Value = varosLak;

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
            if (string.IsNullOrWhiteSpace(txtNev.Text) || string.IsNullOrWhiteSpace(numLak.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
                return; //void metódus futása megszakad return-el
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE varosok SET nev = @nev, lakossag = @lakossag
                                WHERE id = @id";
            cmd.Parameters.AddWithValue("@nev", txtNev.Text);
            cmd.Parameters.AddWithValue("@lakossag", int.Parse(numLak.Text));
            cmd.Parameters.AddWithValue("@id", this.varosId);


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
