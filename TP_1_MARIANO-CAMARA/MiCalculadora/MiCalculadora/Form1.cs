﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            txtResultado.Text = String.Empty;
        }

        private void DecimalBinario_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtResultado.Text)))
                txtResultado.Text = Numero.DecimalBinario(txtResultado.Text);            
        }

        private void BinarioDecimal_click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtResultado.Text))) {
                txtResultado.Text = Numero.BinarioDecimal(txtResultado.Text); 
            }
            }

        public static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int n2;
            double vn1, vn2;
            int operador = comboBox1.SelectedIndex;
            Int32.TryParse(textBox2.Text, out n2);
            if (operador != -1) {
                if (operador == 3 && (String.IsNullOrEmpty(textBox2.Text)) || operador == 3 && n2 == 0){
                    txtResultado.Text = "No se puede dividir por cero";
                    textBox2.Text = "0";
                }
                else{
                    txtResultado.Text = (Operar(textBox1.Text, textBox2.Text, comboBox1.Items[comboBox1.SelectedIndex].ToString())).ToString("0.##");
                }

                if (!(Double.TryParse(textBox1.Text, out vn1))) {
                    textBox1.Text = "0";
                }
                if(!(Double.TryParse(textBox2.Text, out vn2))){
                    textBox2.Text = "0";
                }
                
            }  
  
        }

       

    }
}
