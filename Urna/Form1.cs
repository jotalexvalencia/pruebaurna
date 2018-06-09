using System;
using System.Windows.Forms;

namespace Urna
{
    /// <summary>
    /// Urna con 3 preguntas (Si,No,NSNR)
    /// jorge alexander valencia valencia
    /// </summary>
    public partial class Form1 : Form
    {
        #region Variables
        int votos = 0; // almacena la cantidad de votos
        float si = 0.00f; // almacena la respuesta si
        float no = 0.00f; // almacena la respuesta no
        float nsnr = 0.00f; // almacena la respuesta no sabe/no responde
#endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            votos++;            
            textBox1.Text = String.Format("{0:D}", votos);

            if (rdbSI.Checked) si++;
            if (rdbNO.Checked) no++;               
            if (rdbNSNR.Checked) nsnr++;     
             
            progressBar1.Value = Convert.ToInt32((si / votos) * 100);
            progressBar2.Value = Convert.ToInt32((no / votos) * 100);
            progressBar3.Value = Convert.ToInt32((nsnr / votos) * 100);
            label1.Text = String.Format("{0:P2}.", (si / votos)); 
            label2.Text = String.Format("{0:P2}.", (no / votos)); 
            label3.Text = String.Format("{0:P2}.", (nsnr / votos)); 
            textBox2.Text = si.ToString();
            textBox3.Text = no.ToString();
            textBox4.Text = nsnr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
