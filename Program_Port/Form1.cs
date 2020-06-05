using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Port
{
    public partial class Form1 : Form
    {

        SqlConnection Polaczenie = new SqlConnection("Data Source=.; Database= Porty; Integrated Security= True;");

        public Form1()
        {
            InitializeComponent();
            // tabela_cb.Text = "OsobyTab";
            checkBox1.Checked = true;
            godzina_tb.Text = DateTime.Now.ToString("HH:mm");

            this.dtp.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
        }


        private void display_data()
        {
            Polaczenie.Open();
            SqlCommand cmd = Polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from " + label1.Text + "";
            //cmd.CommandText = "select * from " + label1.Text + " order by Godzina_przybycia ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            Polaczenie.Close();


        }


        private void insert_btn_Click(object sender, EventArgs e)
        {
            Polaczenie.Open();
            SqlCommand cmd = Polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into " + label1.Text + " values('" + id_tb.Text + "'," +
                "'" + kodPortu_tb.Text + "'," +
                "'" + dtp.Value + "'," +
                "'" + godzina_tb.Text + "'," +
                "'" + kodPortuZ_tb.Text + "'," +
                "'" + nazwaStatku_tb.Text + "'," +
                "'" + bandera_tb.Text + "'," +
                "'" + nrIMO_tb.Text + "'," +
                "'" + sygnal_tb.Text + "'," +
                "'" + pojemnosc_tb.Text + "'," +
                "'" + dlugosc_tb.Text + "')";
            cmd.ExecuteNonQuery();
            Polaczenie.Close();
            kodPortu_tb.Text = "";

            kodPortuZ_tb.Text = "";
            nazwaStatku_tb.Text = "";
            bandera_tb.Text = "";
            nrIMO_tb.Text = "";
            sygnal_tb.Text = "";
            pojemnosc_tb.Text = "";
            dlugosc_tb.Text = "";
            display_data();
            MessageBox.Show(" Dodano rekord.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            Polaczenie.Open();
            SqlCommand cmd = Polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from " + label1.Text + " where ID = '" + id_tb.Text + "' or Kod_portu = '" + kodPortu_tb.Text + "' "; 
  
            cmd.ExecuteNonQuery();
            Polaczenie.Close();
            id_tb.Text = "";
            kodPortu_tb.Text = "";           

            display_data();
            MessageBox.Show(" Usunięto rekord.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Polaczenie.Open();
            SqlCommand cmd = Polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from  " + label1.Text + " where ID = '" + id_tb.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            Polaczenie.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            display_data();
            this.dtp.Value = DateTime.Now;
            godzina_tb.Text = DateTime.Now.ToString("HH:mm");
            kodPortu_tb.Text = "";
            kodPortuZ_tb.Text = "";
            nazwaStatku_tb.Text = "";
            bandera_tb.Text = "";
            nrIMO_tb.Text = "";
            sygnal_tb.Text = "";
            pojemnosc_tb.Text = "";
            dlugosc_tb.Text = "";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { //MessageBox.Show("Git");
                checkBox2.Checked = false;
                label1.Text = "Przybycia_1";
                display_data();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            { //MessageBox.Show("Git");
                checkBox1.Checked = false;
                label1.Text = "Wyjscia_1";
                display_data();
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
           // DateTimePicker myPicker = new DateTimePicker();
           // myPicker.Value = DateTime.Now;
        }
    }

}
