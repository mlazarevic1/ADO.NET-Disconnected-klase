using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatPrviDeo
{
    public partial class Form1 : Form
    {

        DataTable kupci = new DataTable("Kupci");
        DataTable fakture = new DataTable("Fakture");
        DataTable faktureStavke = new DataTable("FaktureStavke");
        DataSet fakKupStavke = new DataSet();


        public Form1()
        {
            //Dodavanje kolona u tabelu kupci

            DataColumn kupacID = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1

            };

            kupci.Columns.Add(kupacID);
            kupci.PrimaryKey = new DataColumn[] { kupacID };

            DataColumn NazivKupca = new DataColumn("NazivKupca")
            {
                DataType = typeof(string),
                MaxLength = 50,
                AllowDBNull = false
            };

            kupci.Columns.Add(NazivKupca);

            DataColumn Adresa = new DataColumn("Adresa")
            {
                DataType = typeof(string),
                MaxLength = 200,
                AllowDBNull = false
            };

            kupci.Columns.Add(Adresa);
            
            //--------------------------------------------------------------------------------------
            //Dodavanje kolona u tabelu fakture

            DataColumn fakturaID = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1

            };

            fakture.Columns.Add(fakturaID);
            fakture.PrimaryKey = new DataColumn[] { fakturaID };

            DataColumn KkupacId = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AllowDBNull = false
            };

            fakture.Columns.Add(KkupacId);

            DataColumn datum = new DataColumn("Datum")
            {
                DataType = typeof(DateTime),
                DefaultValue = System.DateTime.Now

            };

            fakture.Columns.Add(datum);

            //--------------------------------------------------------------------------------------------------
            //dodavanje kolona u tabelu FaktureStavke
            DataColumn fakturaIDNazivStavke = new DataColumn("fakturaIDNazivStavke")
            {
                DataType = typeof(string)
                


            };

            faktureStavke.Columns.Add(fakturaIDNazivStavke);

            DataColumn FfakturaID = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AllowDBNull = false

            };

            faktureStavke.Columns.Add(FfakturaID);

            DataColumn NazivStavke = new DataColumn("NazivStavke")
            {
                DataType = typeof(string),
                MaxLength = 40,
                AllowDBNull = false

            };

            faktureStavke.Columns.Add(NazivStavke);

            DataColumn CenaStavke = new DataColumn("CenaStavke")
            {
                DataType = typeof(decimal),
                AllowDBNull = false,

            };

            faktureStavke.Columns.Add(CenaStavke);
            faktureStavke.PrimaryKey = new DataColumn[] { FfakturaID, NazivStavke };


            fakKupStavke.Tables.Add(kupci);
            fakKupStavke.Tables.Add(fakture);
            fakKupStavke.Tables.Add(faktureStavke);

            InitializeComponent();

            //---Prikazivanje tabela u datagridu

            dgKupci.DataSource = kupci;
            dgFakture.DataSource = fakture;
            dgFaktureStavke.DataSource = faktureStavke;


            //----Dodavanje spoljnih kljuceva(Relacije)


            DataRelation dataRelation = new DataRelation("RelacijaKupciFakture", kupci.Columns["KupacID"], fakture.Columns["KupacID"], true);
            fakKupStavke.Relations.Add(dataRelation);

            DataRelation dataRelation2 = new DataRelation("RelacijaFaktureStavkeFakture", fakture.Columns["FakturaID"], faktureStavke.Columns["FakturaID"], true);
            fakKupStavke.Relations.Add(dataRelation2);


            //-- Dodavanje constarint-ova 

            try
            {
                ForeignKeyConstraint fk = (ForeignKeyConstraint)fakture.Constraints["RelacijaKupciFakture"];
                fk.DeleteRule = Rule.None;
                fk.UpdateRule = Rule.None;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            try
            {
                ForeignKeyConstraint fk2 = (ForeignKeyConstraint)faktureStavke.Constraints["RelacijaFaktureStavkeFakture"];
                fk2.DeleteRule = Rule.None;
                fk2.UpdateRule = Rule.None;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };


            //----Binding za kupacID

            cboKupacID.DataSource = kupci;
            cboKupacID.DisplayMember = "Kupac";
            cboKupacID.ValueMember = "KupacID";

            // -----Binding za fakturaID

            cboFakturaID.DataSource = fakture;
            cboFakturaID.DisplayMember = "Faktura";
            cboFakturaID.ValueMember = "FakturaID";



        }

        private void btnUnesiKupca_Click(object sender, EventArgs e)
        {
            try
            {
                kupci.Rows.Add(null, txtNazivKupca.Text, txtAdresa.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnUnesiFakturu_Click(object sender, EventArgs e)
        {
            try
            {
                fakture.Rows.Add(null, cboKupacID.SelectedValue, dtDatum.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            
        }

        private void btnUnesiFakturuIStavku_Click(object sender, EventArgs e)
        {
            try
            {
                faktureStavke.Rows.Add(null, cboFakturaID.SelectedValue, txtNazivStavke.Text, txtCena.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            //--Cuvanje u XML fajl

            fakKupStavke.AcceptChanges();
            fakKupStavke.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FaktureStavke.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Snimljeno");
        }
    }
}
