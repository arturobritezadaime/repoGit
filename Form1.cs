using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Prueba
{
    public partial class Form1 : Form
    {
        int cantham = 0;
        int cantpap = 0;
        int cantbeb = 0;
        const double precioham = 5.5D;
        const double preciopap = 15.5D;
        const double preciobeb = 25.5D;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public double calcular(int cantham = 0, int cantpap = 0, int cantbeb= 0)
        {
            total = (cantbeb * preciobeb) + (cantham * precioham) + (cantpap * preciopap);
            // label1.Text = total.ToString();
            return total;
         }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                cantbeb = 0;
                

            }
            else
            {
                cantbeb = int.Parse(textBox1.Text);
            }
            
            cantham = int.Parse(textBox2.Text);
            cantpap = int.Parse(textBox3.Text);

            //calcular(cantham, cantpap, cantbeb);
            label1.Text= calcular(cantham, cantpap, cantbeb).ToString();
            //para pasar a texto vble.ToString() al final
            // para pasar a valor int.parse(vble) al comienzo

        }

       public void Form1_Load(object sender, EventArgs e)
        {
       
           
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
