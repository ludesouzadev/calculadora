//Visual Studio WinForm Windows Calculator Tutorial Example(C#)
//https://youtu.be/Is1EHXFhEe4?list=PLnJLjmjfLgadZYU9OmRCE-GUcZXT7Nqqa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmCalc : Form
    {
        Double valor = 0;
        String operador = "";
        bool operador_pressionado = false;

        public frmCalc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResu.Text == "0")||(operador_pressionado))
                txtResu.Clear();

            operador_pressionado = false;
            Button b = (Button)sender;
            if (b.Text == ".")
                {
                if(!txtResu.Text.Contains("."))
                    txtResu.Text = txtResu.Text + b.Text;
            }
            else
            txtResu.Text = txtResu.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResu.Text = "0";
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (valor != 0)
            {
                btnIgual.PerformClick();
                operador_pressionado = true;
                operador = b.Text;
                lblEqua.Text = valor + " " + operador;
            }
            else
            {
                operador = b.Text;
                valor = Double.Parse(txtResu.Text);
                operador_pressionado = true;
                lblEqua.Text = valor + " " + operador;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            lblEqua.Text = "";
            switch (operador)
            {
                case "+":
                    txtResu.Text = (valor + Double.Parse(txtResu.Text)).ToString();
                    break;
                case "-":
                    txtResu.Text = (valor - Double.Parse(txtResu.Text)).ToString();
                    break;
                case "*":
                    txtResu.Text = (valor * Double.Parse(txtResu.Text)).ToString();
                    break;
                case "/":
                    txtResu.Text = (valor / Double.Parse(txtResu.Text)).ToString();
                    break;
                default:
                    break;
            }// fim do switch 
            valor = Int32.Parse(txtResu.Text);
            operador = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResu.Text = "0";
            valor = 0;
            lblEqua.Text = "";
        }

        private void frmCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btnZero.PerformClick();
                    break;
                case "1":
                    btnUm.PerformClick();
                    break;
                case "2":
                    btnDois.PerformClick();
                    break;
                case "3":
                    btnTres.PerformClick();
                    break;
                case "4":
                    btnQuatro.PerformClick();
                    break;
                case "5":
                    btnCinco.PerformClick();
                    break;
                case "6":
                    btnSeis.PerformClick();
                    break;
                case "7":
                    btnSete.PerformClick();
                    break;
                case "8":
                    btnOito.PerformClick();
                    break;
                case "9":
                    btnNove.PerformClick();
                    break;
                case "+":
                    btnSoma.PerformClick();
                    break;
                case "-":
                    btnSubt.PerformClick();
                    break;
                case "*":
                    btnMult.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnIgual.PerformClick();
                    break;
                case "ENTER":
                    btnIgual.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
