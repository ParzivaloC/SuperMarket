using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class FormMain : Form
    {
        private List<Product> availableProducts;
        private List<CheckoutItem> checkoutItems;

        public FormMain()
        {
            InitializeComponent();
            InitializeProducts();
            checkoutItems = new List<CheckoutItem>();
        }

        private void InitializeProducts()
        {
            availableProducts = new List<Product>
        {
            new Product("Хлеб", 50),
            new Product("Молоко", 80),
            new Product("Яйца", 120),
            new Product("Сахар", 60),
            new Product("Масло", 150)
        };

            listBoxIsAvailableProduct.DataSource = availableProducts;
            listBoxIsAvailableProduct.DisplayMember = "ToString";
        }

        private void listBoxAvailableProduct_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxIsAvailableProduct.SelectedItem is Product selectedProduct)
            {
                var quantityForm = new QuantityForm(selectedProduct);
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    checkoutItems.Add(new CheckoutItem(selectedProduct, quantityForm.Quantity));
                    UpdateCheckoutList();
                }
            }

        }

        private void UpdateCheckoutList()
        {
            listBoxCheckoutItems.DataSource = null;
            listBoxCheckoutItems.DataSource = checkoutItems;
            listBoxCheckoutItems.DisplayMember = "ToString";
        }

        private void btnCreateCheck_Click(object sender, EventArgs e)
        {
            decimal total = checkoutItems.Sum(item => item.TotalPrice);
            MessageBox.Show($"Общая сумма: {total:C}", "Чек сформирован");
            checkoutItems.Clear();
            UpdateCheckoutList();
        }
    }
