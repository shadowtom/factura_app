using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_factura;
using Ln_factura;


namespace App_factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, desc, Vtotal, TotalP,cant;
            string Error;
            double porc;
            valor = Convert.ToDouble(txt_valor.Text);
            cant = Convert.ToDouble(txt_cantidad.Text);
            //instanciar logics
            ln_factura objOpe = new ln_factura();
            objOpe.set_Valor = valor;
            objOpe.set_Cant = cant;
            #region validar
            if (!objOpe.Calcular())
            {

                MessageBox.Show(objOpe.get_Error);

            }
            else
            {
                txt_totalP.Text = Convert.ToString(objOpe.get_totalP);
                txt_desc.Text = Convert.ToString(objOpe.get_desc);
                txt_Vtotal.Text = Convert.ToString(objOpe.get_Vtotal);
            }
            
               /* MessageBox.Show(objOpe.get_Error);
            txt_totalP.Text= Convert.ToString(objOpe.get_totalP);
            txt_desc.Text = Convert.ToString(objOpe.get_desc);
            txt_Vtotal.Text = Convert.ToString(objOpe.get_Vtotal);*/

            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
