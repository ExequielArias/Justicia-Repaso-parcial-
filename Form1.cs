using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justicia
{
    public partial class frmProfugos : Form
    {
        Profugos oProfugos;
        DataTable tProfugos; 


        public frmProfugos()
        {
            InitializeComponent();
        }

        private void frmProfugos_Load(object sender, EventArgs e)
        {
            oProfugos = new Profugos();
            tProfugos = oProfugos.getData();
            lstNombres.DisplayMember = "nombre";
            lstNombres.ValueMember = "id";
            lstNombres.DataSource = tProfugos;
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow tProfugos in tProfugos.Rows)
            {
                if (tProfugos["id"].ToString() == lstNombres.SelectedValue.ToString())
                {
                    pbFoto.Image = Image.FromFile($"profugos/{tProfugos["foto"]}");
                    lblAlias.Text = (tProfugos["alias"].ToString());
                    DateTime fecha = Convert.ToDateTime(tProfugos["profugo_desde"]);
                    lblProfugoDesde.Text = fecha.ToString("dd/mm/yyyy"); 
                }
            }
        }
    }
}
