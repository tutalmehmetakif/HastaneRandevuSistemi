using HastaneRandevuSistemi.Classes;
using System.Data.SqlClient;

namespace HastaneRandevuSistemi
{
    public partial class Form1 : Form
    {

        string connectionString = "Server=DESKTOP-TS45LQ5;Database=HastaRandevuSistemi;Integrated Security=True;";
        int secilenBransId = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BransGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Brans> bransListesi = null;

                try
                {
                    connection.Open();
                    string sorgu = "select * from Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    bransListesi = new List<Brans>();
                    bransListesi.Add(new Brans
                    {
                        Id = -1,
                        BransAdi = "Lütfen Branþý seçiniz"

                    });

                    while (reader.Read())
                    {
                        bransListesi.Add(new Brans
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            BransAdi = reader["BransAdi"].ToString()

                        });
                    }

                    cmbBrans.DataSource = bransListesi;
                    cmbBrans.DisplayMember = "BransAdi";
                    cmbBrans.ValueMember = "Id";



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        public void DoktorGetir(int bransId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Doktor> doktorListesi = new List<Doktor>();
                try
                {
                    connection.Open();
                    string sorgu = "SELECT * FROM Doktorlar WHERE BransId = " + bransId;
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    doktorListesi.Add(new Doktor
                    {
                        DoktorId = -1,
                        DoktorAdi = "Lütfen",
                        DoktorSoyadi = "doktor seçiniz"
                    });

                    while (reader.Read())
                    {
                        doktorListesi.Add(new Doktor
                        {
                            DoktorId = Convert.ToInt32(reader["DoktorId"]),
                            DoktorAdi = reader["DoktorAdi"].ToString(),
                            DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                            BransId = Convert.ToInt32(reader["BransId"]),

                        });

                    }
                    cmbDoktor.DataSource = doktorListesi;
                    cmbDoktor.DisplayMember = "TamAdi";
                    cmbDoktor.ValueMember = "DoktorId";


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransGetir();
            SaatleriYukle();

            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans secilenBrans = (Brans)cmbBrans.SelectedItem;
            secilenBransId = secilenBrans.Id;

            if (secilenBrans.Id > 0)
            {
                DoktorGetir(secilenBrans.Id);
            }
        }

        public void SaatleriYukle()
        {
            cmbSaat.Items.Clear();

            cmbSaat.Items.Add("Lütfen bir saat seçiniz");


            for (int saat = 9; saat <= 17; saat++) // 09:00 - 17:00 arasý
            {
                cmbSaat.Items.Add($"{saat}:00");
                cmbSaat.Items.Add($"{saat}:30");
            }

            cmbSaat.SelectedIndex = 0; // varsayýlan seçim
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hastaAdi = txtHastaAdi.Text;
            string hastaSoyadi = txtHastaSoyadi.Text;
            int bransId = (int)cmbBrans.SelectedValue;
            int doktorId = (int)cmbDoktor.SelectedValue;
            DateTime tarih = dtpTarih.Value.Date;
            string saatStr = cmbSaat.SelectedItem.ToString();


            DateTime randevuZamani = DateTime.Parse($"{tarih.ToShortDateString()} {saatStr}");

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                try
                {
                    connection.Open();
                    string sorgu = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransId, DoktorId, Tarih) " +
                  "VALUES (@adi, @soyadi, @bransId, @doktorId, @tarih)";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@adi", hastaAdi);
                    command.Parameters.AddWithValue("@soyadi", hastaSoyadi);
                    command.Parameters.AddWithValue("@bransId", bransId);
                    command.Parameters.AddWithValue("@doktorId", doktorId);
                    command.Parameters.AddWithValue("@tarih", randevuZamani);                 
                    command.ExecuteNonQuery();
                    DialogResult dialogResult = MessageBox.Show(
                        $"{hastaAdi} " + $"{hastaSoyadi} Randevunuz Baþarýyla Oluþturuldu",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            } ;

        }
    }
}
