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
    public partial class F_List_Paimant : Form
    {
        public F_List_Paimant()
        {
            InitializeComponent();
        }

        autoEcoleEntities db = new autoEcoleEntities();

        private void Frm_load()
        {

            dgv_paiement.DataSource = db.Paiements.Select(a => new
            {

                Bon = a.numBon,
                Participant = a.Participant.numP,
                Prix = a.prixPaye,
                Date = a.date_

            }).ToList();

        }

        private void F_List_Paimant_Load(object sender, EventArgs e)
        {
            Frm_load();
        }
    }
}
