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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            model.numBon = int.Parse(txt_numBon.Text);
            model.numP = int.Parse(cmb_participant.SelectedValue.ToString());
            model.prixPaye = int.Parse(txt_prix.Text);
            model.date_ = dtp_date.Value;
            db.Paiements.Add(model);
            db.SaveChanges();
            this.Close();
        }

        private void AM_paiment_Load(object sender, EventArgs e)
        {
            cmb_participant.DataSource = db.Participants.ToList();
            cmb_participant.ValueMember = "numP";
            cmb_participant.DisplayMember = "nomP";
        }
    }
}
