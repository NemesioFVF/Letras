using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList v = new ArrayList();
        String contrario;
        int contador=0, i, j, vo, co, contador2 = 0, pali;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void badd_Click(object sender, EventArgs e)
        {
            v.Add(nome.Text);
            contador++;
            nome.Clear();
            nome.Focus();

   
           }

        private void nota_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bl_Click(object sender, EventArgs e)
        {
            consoantes.Text = "";
            vogais.Text = "";
            v.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String a in v)
            {
                list.Items.Add(a);

                if (a.Substring(0, 1).Equals("A") || a.Substring(0, 1).Equals("E") || a.Substring(0, 1).Equals("I") || a.Substring(0, 1).Equals("O") || a.Substring(0, 1).Equals("U") || a.Substring(0, 1).Equals("a") || a.Substring(0, 1).Equals("e") || a.Substring(0, 1).Equals("i") || a.Substring(0, 1).Equals("o") || a.Substring(0, 1).Equals("u"))
                {
                    vo++;
                }
                else
                {
                    co++;
                }

                contrario = "";
                contador2 = a.Length - 1;
                for (; contador2 >= 0; contador2 = contador2 - 1)
                {
                    contrario = contrario + a.Substring(contador2, 1);
                }
                    
                if (a.Equals(contrario))
                {
                    pali++;
                }
            }

            palindrome.Text = pali + "";
            vogais.Text = vo + "";
            consoantes.Text = co + "";
       }
    }
}
