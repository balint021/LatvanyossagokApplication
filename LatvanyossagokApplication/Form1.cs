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
    public partial class Form1 : Form
    {

        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
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
            feladat2();
            AdatokListazasa();
        }

        private void feladat2()
        {
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = @"CREATE TABLE IF NOT EXISTS varosok(
                                        id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                                        nev varchar(255) UNIQUE NOT NULL,
                                        lakossag int NOT NULL
                                    );";
                command.ExecuteNonQuery();

                command.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossagok(
                                        id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                                        nev varchar(255) NOT NULL,
                                        leiras varchar(255) NOT NULL,
                                        ar int DEFAULT 0 NOT NULL,
                                        varos_id int NOT NULL,
                                        FOREIGN KEY (varos_id) REFERENCES varosok(id)
                                    );";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
            
        }

        private void AdatokListazasa()
        {
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = @"SELECT id, nev, lakossag FROM varosok";
                using (var reader = command.ExecuteReader())
                {
                    varosBox.Items.Clear();
                    latv_varosBox.Items.Clear();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var lakossag = reader.GetInt32("lakossag");

                        var varos = new Varos(id, nev, lakossag);

                        varosBox.Items.Add(varos);
                        latv_varosBox.Items.Add(varos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
            
        }

        private void btn_varosAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(varosNev.Text) || string.IsNullOrWhiteSpace(num_varosLak.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
                return; //void metódus futása megszakad return-el
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES (@nev, @lakossag)";
            cmd.Parameters.AddWithValue("@nev", varosNev.Text);
            cmd.Parameters.AddWithValue("@lakossag", int.Parse(num_varosLak.Text));


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            AdatokListazasa();
        }

        private void btn_varosTorol_Click(object sender, EventArgs e)
        {
            if (varosBox.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez");
                return;
            }

            var varos = (Varos)varosBox.SelectedItem;

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM varosok WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", varos.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem törölheted mert van látványossága.");
            }

            

            AdatokListazasa();
        }

        private void btn_LatvAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(latvNev.Text) || string.IsNullOrWhiteSpace(latvLeir.Text) ||
                latv_varosBox.SelectedIndex == -1)
            {
                MessageBox.Show("Ne hagyj üresen mezőt.");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO latvanyossagok (nev, leiras, ar, varos_id)
                                VALUES (@nev, @leiras, @ar, @vId)";
            cmd.Parameters.AddWithValue("@nev", latvNev.Text);
            cmd.Parameters.AddWithValue("@leiras", latvLeir.Text);
            cmd.Parameters.AddWithValue("@ar", int.Parse(num_latvAr.Text));
            var varos = (Varos)latv_varosBox.SelectedItem;
            cmd.Parameters.AddWithValue("@vId", varos.Id);


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (varosBox.SelectedIndex != -1)
            {
                LatvListaFrissites();
            }

        }

        private void varosBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            latvBox.Items.Clear();

            try
            {
                var command = conn.CreateCommand();
                command.CommandText = @"SELECT id, nev, leiras, ar, varos_id FROM latvanyossagok WHERE varos_id = @id";
                var varos = (Varos)varosBox.SelectedItem;
                command.Parameters.AddWithValue("@id", varos.Id);

                using (var reader = command.ExecuteReader())
                {
                    latvBox.Items.Clear();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var varos_id = reader.GetInt32("varos_id");

                        var latv = new Latvanyossag(id, nev, leiras, ar, varos_id);

                        latvBox.Items.Add(latv);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void btn_latvDel_Click(object sender, EventArgs e)
        {
            if (latvBox.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez");
                return;
            }
            var cmd = conn.CreateCommand();

            cmd.CommandText = @"DELETE FROM latvanyossagok WHERE id = @id";

            var latv = (Latvanyossag)latvBox.SelectedItem;

            cmd.Parameters.AddWithValue("@id", latv.Id);

            cmd.ExecuteNonQuery();

            LatvListaFrissites();

        }

        private void LatvListaFrissites()
        {
            latvBox.Items.Clear();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = @"SELECT id, nev, leiras, ar, varos_id FROM latvanyossagok WHERE varos_id = @id";
                var varos = (Varos)varosBox.SelectedItem;
                command.Parameters.AddWithValue("@id", varos.Id);
                using (var reader = command.ExecuteReader())
                {
                    latvBox.Items.Clear();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var varos_id = reader.GetInt32("varos_id");

                        var latv = new Latvanyossag(id, nev, leiras, ar, varos_id);

                        latvBox.Items.Add(latv);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_varosUpdate_Click(object sender, EventArgs e)
        {
            if (varosBox.SelectedItem != null)
            {
                var varos = (Varos)varosBox.SelectedItem;
                Form varosModositasForm = new VarosModositasForm(varos.Id, varos.Nev, varos.Lakossag);
                varosModositasForm.ShowDialog();
            }   
        }

        private void btn_latvUpdate_Click(object sender, EventArgs e)
        {
            if (latvBox.SelectedItem !=null)
            {
                var latv = (Latvanyossag)latvBox.SelectedItem;
                Form LatvanyossagModositasForm = new LatvanyossagModositasForm(latv.Id, latv.Nev, latv.Leiras, latv.Ar);
                LatvanyossagModositasForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdatokListazasa();
        }
    }
}
