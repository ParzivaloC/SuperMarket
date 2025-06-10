using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class QuantityForm : Form
    {
        public int Quantity => (int)numQuantity.Value;
        public Product SelectedProduct { get;}


        public QuantityForm(Product product)
        {
            InitializeComponent();
            SelectedProduct = product;
            this.Text = $"Введите количество для {product.Name}";
            buttonConfirm.Click += buttenConfirm_Click;
        }

        private void buttenConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
