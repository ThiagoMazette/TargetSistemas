using System;
using System.Windows.Forms;

namespace TargetSistemas
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;
                      
            double totalFaturamento = SP + RJ + MG + ES + Outros;
          
            double percentualSP = (SP / totalFaturamento) * 100;
            double percentualRJ = (RJ / totalFaturamento) * 100;
            double percentualMG = (MG / totalFaturamento) * 100;
            double percentualES = (ES / totalFaturamento) * 100;
            double percentualOutros = (Outros / totalFaturamento) * 100;

            
            txtSP.Text = percentualSP.ToString("F2")+"%";
            txtRJ.Text = percentualRJ.ToString("F2")+"%";
            txtMG.Text = percentualMG.ToString("F2") + "%";
            txtES.Text = percentualES.ToString("F2") + "%";
            txtOutros.Text = percentualOutros.ToString("F2") + "%";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
