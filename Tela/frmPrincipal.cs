using System;
using System.Windows.Forms;

namespace TargetSistemas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            frmExercicio2 _f = new frmExercicio2();
            _f.ShowDialog();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            frmExercicio3 _f = new frmExercicio3();
            _f.ShowDialog();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            frmExercicio4 _f = new frmExercicio4();
            _f.ShowDialog();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            frmExercicio5 _f = new frmExercicio5();
            _f.ShowDialog();
        }
    }
}
