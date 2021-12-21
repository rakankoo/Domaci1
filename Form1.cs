using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Domaci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cs= @"Data source = DESKTOP-VPCQNUN\SQLEXPRESS; Initial catalog = stavka; Integrated security = true";
        SqlConnection veza;
        DataTable tabela = new DataTable();
        SqlDataAdapter adapter;
        int indeks = 0;
        int id, kom, cena, popust;

        void refresh()
        {
            if (tabela.Rows.Count==0)
            {
                tbCENA.Text = "";
                tbID.Text = "";
                tbKOM.Text = "";
                tbPOPUST.Text = "";
                btADD.Enabled = false;
                btNEXT.Enabled = false;
                btDELETE.Enabled = false;
                btKRAJ.Enabled = false;
                btPREV.Enabled = false;
                btPOCETAK.Enabled = false;
                btUPDATE.Enabled = false;
                btADDNEW.Enabled = true;
                return;
            }
            else
            {
                tbID.Text = tabela.Rows[indeks]["id"].ToString();
                tbCENA.Text = tabela.Rows[indeks]["cena"].ToString();
                tbKOM.Text = tabela.Rows[indeks]["kom"].ToString();
                tbPOPUST.Text = tabela.Rows[indeks]["popust"].ToString();
            }

            if (indeks == tabela.Rows.Count-1)
            {
                btNEXT.Enabled = false;
                btKRAJ.Enabled = false;
            }
            else
            {
                btNEXT.Enabled = true;
                btKRAJ.Enabled = true;
            }

            if (indeks==0)
            {
                btPOCETAK.Enabled = false;
                btPREV.Enabled = false;
            }
            else
            {
                btPOCETAK.Enabled = true;
                btPREV.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btADD.Enabled = false;
            btNEXT.Enabled = false;
            btDELETE.Enabled = false;
            btKRAJ.Enabled = false;
            btPREV.Enabled = false;
            btPOCETAK.Enabled = false;
            btUPDATE.Enabled = false;
            btADDNEW.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            btNEXT.Enabled = true;
            btDELETE.Enabled = true;
            btKRAJ.Enabled = true;
            btPREV.Enabled = true;
            btPOCETAK.Enabled = true;
            btUPDATE.Enabled = true;
            btADDNEW.Enabled = true;
            tbCENA.Enabled = true;
            tbKOM.Enabled = true;
            tbPOPUST.Enabled = true;
            button1.Hide();
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from artikal", veza);
            adapter.Fill(tabela);
            tbCENA.Text = tabela.Rows.Count.ToString();
            refresh();
        }

        private void btNEXT_Click(object sender, EventArgs e)
        {
            indeks++;
            refresh();
        }

        private void btPREV_Click(object sender, EventArgs e)
        {
            indeks--;
            refresh();
        }

        private void btDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(tbID.Text);
                veza.Open();
                SqlCommand uradi = new SqlCommand($"delete from artikal where id={id}",veza);
                uradi.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
                adapter = new SqlDataAdapter("select * from artikal", veza);
                adapter.Fill(tabela);
                if (indeks == tabela.Rows.Count) indeks--;
                refresh();
                MessageBox.Show("Podatak uspesno obrisan");
            }
            catch
            {
                MessageBox.Show("Nismo mogli da obrisemo podatak. Pokusajte ponovo");
            }
            
        }

        private void btADDNEW_Click(object sender, EventArgs e)
        {
            tbCENA.Text = "";
            tbID.Text = "";
            tbKOM.Text = "";
            tbPOPUST.Text = "";
            btADD.Enabled = true;
            btNEXT.Enabled = false;
            btDELETE.Enabled = false;
            btKRAJ.Enabled = false;
            btPREV.Enabled = false;
            btPOCETAK.Enabled = false;
            btUPDATE.Enabled = false;
            btADDNEW.Enabled = false;
            tbCENA.Enabled = true;
            tbKOM.Enabled = true;
            tbPOPUST.Enabled = true;
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            btADD.Enabled = false;
            btNEXT.Enabled = true;
            btDELETE.Enabled = true;
            btKRAJ.Enabled = true;
            btPREV.Enabled = true;
            btPOCETAK.Enabled = true;
            btUPDATE.Enabled = true;
            btADDNEW.Enabled = true;
            tbCENA.Enabled = true;
            tbKOM.Enabled = true;
            tbPOPUST.Enabled = true;
            try
            {
                cena = Convert.ToInt32(tbCENA.Text);
                popust = Convert.ToInt32(tbPOPUST.Text);
                kom = Convert.ToInt32(tbKOM.Text);
                SqlCommand uradi = new SqlCommand($"insert into artikal values({kom},{cena},{popust})",veza);
                veza.Open();
                uradi.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
                adapter = new SqlDataAdapter("select * from artikal", veza);
                adapter.Fill(tabela);
                indeks = tabela.Rows.Count - 1;
                refresh();
                MessageBox.Show("Podatak uspesno dodat");
            }
            catch
            {
                MessageBox.Show("Neuspesno dodavanje podataka. Pokusajte ponovo");
                refresh();
            }
        }

        private void btKRAJ_Click(object sender, EventArgs e)
        {
            indeks = tabela.Rows.Count - 1;
            refresh();
        }

        private void btPOCETAK_Click(object sender, EventArgs e)
        {
            indeks = 0;
            refresh();
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(tbID.Text);
                kom = Convert.ToInt32(tbKOM.Text);
                cena = Convert.ToInt32(tbCENA.Text);
                popust = Convert.ToInt32(tbPOPUST.Text);
                veza.Open();
                SqlCommand uradi = new SqlCommand($"update artikal set kom={kom}, cena={cena}, popust={popust} where id={id}", veza);
                uradi.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
                adapter = new SqlDataAdapter("select * from artikal", veza);
                adapter.Fill(tabela);
                refresh();
                MessageBox.Show("Uspesno azuriran podatak");
            }
            catch
            {
                MessageBox.Show("Nismo uspeli da azuriramo podatke, pokusajte ponovo");
            }
            
            
        }
    }
}
