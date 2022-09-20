using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_Con_Get_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            clsuma suma = new clsuma();
            suma.V1 = int.Parse(txtv1.Text);
            suma.V2 = int.Parse(txtv2.Text);

            txtresult.Text = suma.sumar().ToString();
        }
    }
}
