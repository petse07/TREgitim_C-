using TREgitim.ArabaConstructor;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TREgitim
{
    public partial class Form1 : Form
    {

        Matematik m;
        ArabaKasasi kasa;
        ArabaModeli model;
        ArabaMarkasi marka;
        string connectionstring = @"Data Source= DESKTOP-3GKFLD8;Initial Catalog=candb ;Integrated Security=SSPI";
        int MarkaID;
        int ModelID;
        int KasaID;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new Matematik();
            int readData = Convert.ToInt32(textBox1.Text);

            int yas = m.yasHesapla(readData);
            MessageBox.Show("Yaþýnýz:" + Convert.ToString(yas));
            //label1.Text = "Yaþýnýz:";
            textBox1.Text = Convert.ToString(yas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Araba yeni = new Araba(Convert.ToInt32(kapisayisi.Text), Convert.ToInt32(penceresayisi.Text), kasa, model, marka);
            //string gelenMesaj = yeni.siparisYaz();
            //Sipariþ.Text = gelenMesaj;
            //Sipariþ.Visible = true;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string sorguSiparis = " insert into Araba(MARKA_ID,MODEL_ID,KASA_ID,KAPI_SAYISI,PENCERE_SAYISI) Values("+MarkaID+","+ModelID+","+KasaID+","+Convert.ToInt32(kapisayisi.Text)+ ","+ Convert.ToInt32(penceresayisi.Text)+")";
                    SqlCommand cmd = new SqlCommand(sorguSiparis, connection);
                    cmd.ExecuteNonQuery();
                    kapisayisi.Text = "";
                    penceresayisi.Text = "";
                    Markacmb.SelectedIndex = 0;
                    Modelcmb.SelectedIndex = 0;
                    Kasacmb.SelectedIndex = 0;
                    MessageBox.Show("Sipariþ Baþarýlý");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    MessageBox.Show("Sipariþ Baþarýsýz");
                }
                finally
                {
                    connection.Close();
                }


            }

        }

        private void Markacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka = new ArabaConstructor.ArabaMarkasi(Markacmb.SelectedItem.ToString());
            MarkaID = Markacmb.SelectedIndex;
            ModelGetir(MarkaID);
        }

        private void Modelcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = new ArabaConstructor.ArabaModeli(Modelcmb.SelectedItem.ToString());
            ModelID = Modelcmb.SelectedIndex;
        }

        private void Kasacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            kasa = new ArabaConstructor.ArabaKasasi(Kasacmb.SelectedItem.ToString());
            KasaID = Kasacmb.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            KasaGetir();
            SiparisGetir();
        }

        public void MarkaGetir()
        {
            List<ArabaMarkasi> markaList = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string sorguMarka = " select * from Marka";
                    SqlCommand cmd = new SqlCommand(sorguMarka, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    markaList = new List<ArabaMarkasi>();

                    markaList.Add(new ArabaMarkasi
                    {
                        id = -1,
                        markasi = "Marka Seçiniz"
                    });


                    while (reader.Read())
                    {
                        markaList.Add(new ArabaMarkasi
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            markasi = (string)reader["MARKASI"]
                        });


                    }



                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                Markacmb.DataSource = markaList;
                Markacmb.DisplayMember = "markasi";
                Markacmb.ValueMember = "id";


            }


        }


        public void ModelGetir(int MarkaID)
        {
            List<ArabaModeli> modelList = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string sorguModel = "select * from Model where MARKA_ID="+MarkaID;
                    SqlCommand cmd = new SqlCommand(sorguModel, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    modelList = new List<ArabaModeli>();

                    modelList.Add(new ArabaModeli
                    {
                        id = -1,
                        modeli = "Model Seçiniz"

                    });

                    while (reader.Read())
                    {
                        modelList.Add(new ArabaModeli
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            modeli = (string)reader["MODELI"]
                            
                        });


                    }



                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                Modelcmb.DataSource = modelList;
                Modelcmb.DisplayMember = "modeli";
                Modelcmb.ValueMember = "id";
            }
        }


        public void KasaGetir()
        {
            List<ArabaKasasi> kasaList = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string sorguKasa = "select * from Kasa";
                    SqlCommand cmd = new SqlCommand(sorguKasa, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    kasaList = new List<ArabaKasasi>();

                    kasaList.Add(new ArabaKasasi
                    {
                        id = -1,
                        kasatipi = "Kasa Seçiniz"

                    });

                    while (reader.Read())
                    {
                        kasaList.Add(new ArabaKasasi
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            kasatipi = (string)reader["TIPI"]

                        });


                    }



                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                Kasacmb.DataSource = kasaList;
                Kasacmb.DisplayMember = "kasatipi";
                Kasacmb.ValueMember = "id";
            }
        }


        public void SiparisGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select A.*,M.Markasý,MO.MODELI,K.TIPI as [KASA TÝPÝ] from Araba as A inner join Marka as M on M.ID = A.MARKA_ID inner join Model as MO on MO.ID = A.MODEL_ID inner join Kasa as K on K.ID = A.KASA_ID",connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Araba");
                    dataGridView1.DataSource = ds.Tables["Araba"];

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();

                }
                finally
                {
                    connection.Close();
                }


            }

        }
    }


       
}