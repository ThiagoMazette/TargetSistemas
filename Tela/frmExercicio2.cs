using System;
using System.Windows.Forms;

namespace TargetSistemas
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            int proximo;
            int numero = Convert.ToInt32(txtmskNumero.Text);

            if (numero == 0 || numero == 1)
            {
                lblResposta.Text = "O número "+numero+" pertence à sequência de Fibonacci";
                return;
            }            
            while (b < numero)
            {
                proximo = a + b;
                a = b;
                b = proximo;
            }
                        
            if (b == numero)
            {
                lblResposta.Text = "O número "+numero+" pertence à sequência de Fibonacci";
            }
            else
            {
                lblResposta.Text = "O número "+numero+" NÃO pertence à sequência de Fibonacci";
            }
        }
    }
}
