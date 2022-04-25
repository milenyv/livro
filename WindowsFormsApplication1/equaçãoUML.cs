using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class equaçãoUML
    {
         public partial class Eqsegundograu : Form
    {
        equaçãoUML equação = new equaçãoUML();
        public equação()
        {
            eqsegundograu();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            texta.Clear();
            textb.Clear();
            textc.Clear();
            text.Clear();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Eqsegundograu.seta(texta.Text);
            Eqsegundograu.setb(textb.Text);
            Eqsegundograu.setc(textc.Text);
            Eqsegundograu.validaDados();

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Seus dados foram salvos com sucesso.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            texta.Text = Eqsegundograu.geta();
            textb.Text = Eqsegundograu.getb();
            textc.Text = Eqsegundograu.getc();
           
}
