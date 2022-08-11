using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TREgitim.Odeme;
using Microsoft.Data.SqlClient;

namespace TREgitim
{
    public partial class OdemeFormu : Form
    {

        string connectionstring = @"Data Source= DESKTOP-3GKFLD8;Initial Catalog=candb ;Integrated Security=SSPI";
        private List<OdemeTipi> odemetipleri;

        public OdemeFormu()
        {
            InitializeComponent();
        }

        private void OdemeYap_Click(object sender, EventArgs e)
        {


            #region combobox
            //string secilenodemetipi = OdemeTipicmb.Text;
            string secilenodemetipi = OdemeTipicmb.SelectedValue.ToString();
            OdemeIslemleriFactory odemeIslemleriFactory = new OdemeIslemleriFactory();
            IOdeme iodeme;

            try 
            {
                iodeme = odemeIslemleriFactory.GetInstance(secilenodemetipi);
                OdemeIslemleri od = new OdemeIslemleri(iodeme);
                string gelenmesaj = od.OdemeYap(Convert.ToInt32(tutartxtbox.Text));
                MessageBox.Show(gelenmesaj);

            }

            catch(Exception ex)
            {
                ex.ToString();

            }
            #endregion


            #region database

            #endregion

            //OdemeIslemleri odemeislemleri = new OdemeIslemleri();
        }

        private void OdemeFormu_Load(object sender, EventArgs e)
        {
            OdemeGetir();
        }

        public void OdemeGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string sorguOdeme = " select * from  OdemeTipleri";
                    SqlCommand cmd = new SqlCommand(sorguOdeme, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    odemetipleri = new List<OdemeTipi>();



                    while (reader.Read())
                    {
                        odemetipleri.Add(new OdemeTipi
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            className = (string)reader["CLASS_NAME"],
                            displayName = (string)reader["DISPLAY_NAME"]
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

                OdemeTipicmb.DataSource = odemetipleri;
                OdemeTipicmb.DisplayMember = "displayName";
                OdemeTipicmb.ValueMember = "className";


            }
        }
    }
}
