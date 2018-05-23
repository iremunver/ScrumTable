using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scrum
{
    public partial class Scrum : Form
    {
        public Scrum()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbScrum.accdb");
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet dr = new DataSet();
        public int i = 0;
        DateTime Tarih = DateTime.Now;
        public string KullaniciAdi { get; set; }


        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Scrum (story,Ad) VALUES ('" + txtStory.Text + "', '" + txtAdSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            

            MessageBox.Show("KAYIT EDİLDİ");

            txtStory.Clear();
            txtAdSoyad.Clear();
            HikayeListele();
        }

        Label[] story;
        void HikayeListele()
        {
            flowLayoutStory.Controls.Clear();
            flowLayoutDone.Controls.Clear();
            flowLayoutInProgress.Controls.Clear();
            flowLayoutNotStarted.Controls.Clear();
            cmbTask.Items.Clear();
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM Scrum", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());

            story = new Label[storySayisi];

            for (i = 0; i < storySayisi; i++)
            {
                story[i] = new Label();

                story[i].Width = 150;
                story[i].Height = 100;
                flowLayoutStory.Controls.Add(story[i]);

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Scrum ", baglanti);
                da.Fill(dt);
                story[i].Text = dt.Rows[i][1].ToString() + Environment.NewLine + dt.Rows[i][2].ToString() + Environment.NewLine + dt.Rows[i][3].ToString();
                cmbTask.Items.Add(dt.Rows[i][1].ToString());
                baglanti.Close();

            }
            baglanti.Close();
        }

        private void Scrum_Load(object sender, EventArgs e)
        {
            HikayeListele();
            TaskListele();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO task (Ad,metin,story,Durum,Tarih) VALUES ('" + txtAdSoyad.Text + "', '" + txtTask.Text + "', '" + cmbTask.SelectedItem.ToString() + "', '" + "NotStarted" + "', '" + dtpTask.Value.Date + "')", baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            
            MessageBox.Show("KAYIT EDİLDİ");

            txtTask.Clear();
            txtAdSoyad.Clear();
            TaskListele();
        }
        void TaskListele()
        {
            flowLayoutDone.Controls.Clear();
            flowLayoutInProgress.Controls.Clear();
            flowLayoutNotStarted.Controls.Clear();
            cmbTaskdegistir.Items.Clear();
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM task ", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());

          

            story = new Label[storySayisi];

            for (i = 0; i < storySayisi; i++)
            {
                story[i] = new Label();
                story[i].Width = 150;
                story[i].Height = 100;
                
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from task ", baglanti);
            
                da.Fill(dt);
                cmbTaskdegistir.Items.Add(dt.Rows[i][2]);
                if (dt.Rows[i][4].ToString() == "NotStarted")
                    flowLayoutNotStarted.Controls.Add(story[i]);
                else if (dt.Rows[i][4].ToString() == "InProgress")
                    flowLayoutInProgress.Controls.Add(story[i]);
                else if (dt.Rows[i][4].ToString() == "Done")
                    flowLayoutDone.Controls.Add(story[i]);
                
                story[i].Text = dt.Rows[i][1].ToString() + Environment.NewLine + dt.Rows[i][2].ToString() + Environment.NewLine + dt.Rows[i][3].ToString()+Environment.NewLine+dt.Rows[i][5].ToString();
                //dt.Rows[i][3] = cmbTask.Items.Add(txtStory.Text);
                baglanti.Close();
            }
            baglanti.Close();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            komut.CommandText = "UPDATE task SET Durum=@Durum WHERE Metin=@Metin";
            komut.Parameters.AddWithValue("@Durum", cmbTaskDurum.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Metin", cmbTaskdegistir.SelectedItem.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TaskListele();
        }
    }
}
