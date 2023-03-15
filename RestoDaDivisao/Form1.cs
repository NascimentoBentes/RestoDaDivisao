using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void btnRealizaDivisao_Click(object sender, EventArgs e)
        {
            //Realiza a conversão para inteiro e armazena em uma nova variável.
            //Realiza a operação para obter o resto da divisão e atribui
            //o resultado na variavel "resto"
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtRestoDaDivisao.Text = resto.ToString();
        }
        //A implementação realizada não trabalhou a hipótese de o usuário digitar
        //no divisor o valor 0 (zero).
    }
}
