using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class AM_paiment : Form
    {
        public AM_paiment()
        {
            InitializeComponent();
        }

        autoEcoleEntities db = new autoEcoleEntities();
        Paiement model = new Paiement();
        public string name_button;
        public int numBon;

        private void Frm_load()
        {
            cmb_participant.DataSource = db.Participants.ToList();
            cmb_participant.ValueMember = "numP";
            cmb_participant.DisplayMember = "nomP";
            BtnSave.Text = name_button;
            if (BtnSave.Text == "Modiffier") //fill the form
            {
                model = db.Paiements.Find(numBon);
                txt_numBon.Text = model.numBon.ToString();
                cmb_participant.SelectedValue = model.Participant.numP;
                txt_prix.Text = model.prixPaye.ToString();
                dtp_date.Value = model.date_;
            }
        }

        private void AM_paiment_Load(object sender, EventArgs e)
        {
            Frm_load();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.Text == "Ajouter")
            {
                model.numBon = int.Parse(txt_numBon.Text);
                model.numP = int.Parse(cmb_participant.SelectedValue.ToString());
                model.prixPaye = int.Parse(txt_prix.Text);
                model.date_ = dtp_date.Value;
                db.Paiements.Add(model);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("paiement ajouter avec succe");
            }
            else if (BtnSave.Text == "Modiffier")
            {

                model.numBon = int.Parse(txt_numBon.Text);
                model.numP = int.Parse(cmb_participant.SelectedValue.ToString());
                model.prixPaye = decimal.Parse(txt_prix.Text);
                model.date_ = dtp_date.Value;
                db.SaveChanges();
                MessageBox.Show("paiement modifier avec suce");
            }

        }
    }
}
