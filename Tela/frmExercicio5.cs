using System;
using System.Windows.Forms;

namespace TargetSistemas
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtInverter.Text))
            {
                MessageBox.Show("Digite algo para inverter", "Digite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInverter.Focus();
                return;
            }
            string Texto = txtInverter.Text;                       
            string TextoInvertido = "";
                        
            for (int i = Texto.Length - 1; i >= 0; i--)
            {
                TextoInvertido += Texto[i];
            }
                  
            txtInvertido.Text = TextoInvertido;        
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
