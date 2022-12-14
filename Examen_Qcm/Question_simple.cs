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

namespace Examen_Qcm
{
    public partial class Question_simple : Form
    {
        public Question_simple()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtbox_numero.Text = "";
            txtbox_question.Text = "";
            textBox_prp.Text = "";
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
        private void btn_confirmer_Click(object sender, EventArgs e)
        {

            if (txtbox_numero.Text == "" || txtbox_question.Text == "" || textBox_prp.Text=="")
            {
                MessageBox.Show("Compléter les données!!");
            }
            else
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand(" insert into Question_s(Numero,Question,Mot_cle) values" +
                        "('" + txtbox_numero.Text + "','" + txtbox_question.Text + 
                        "','"+ textBox_prp.Text + "')", cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question bien enregistré ");
                    cnx.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
