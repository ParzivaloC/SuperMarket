namespace SuperMarket
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAvailableProduct = new System.Windows.Forms.ListBox();
            this.listBoxCheckoutItems = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCreateCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAvailableProduct
            // 
            this.listBoxAvailableProduct.FormattingEnabled = true;
            this.listBoxAvailableProduct.ItemHeight = 16;
            this.listBoxAvailableProduct.Location = new System.Drawing.Point(97, 50);
            this.listBoxAvailableProduct.Name = "listBoxAvailableProduct";
            this.listBoxAvailableProduct.Size = new System.Drawing.Size(120, 84);
            this.listBoxAvailableProduct.TabIndex = 0;
            // 
            // listBoxCheckoutItems
            // 
            this.listBoxCheckoutItems.FormattingEnabled = true;
            this.listBoxCheckoutItems.ItemHeight = 16;
            this.listBoxCheckoutItems.Location = new System.Drawing.Point(595, 50);
            this.listBoxCheckoutItems.Name = "listBoxCheckoutItems";
            this.listBoxCheckoutItems.Size = new System.Drawing.Size(120, 84);
            this.listBoxCheckoutItems.TabIndex = 1;
            // 
            // buttonCreateCheck
            // 
            this.buttonCreateCheck.Location = new System.Drawing.Point(335, 111);
            this.buttonCreateCheck.Name = "buttonCreateCheck";
            this.buttonCreateCheck.Size = new System.Drawing.Size(138, 23);
            this.buttonCreateCheck.TabIndex = 2;
            this.buttonCreateCheck.Text = "Выдать чек";
            this.buttonCreateCheck.UseVisualStyleBackColor = true;
            this.buttonCreateCheck.Click += new System.EventHandler(this.buttenCreateCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вывод суммы";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateCheck);
            this.Controls.Add(this.listBoxCheckoutItems);
            this.Controls.Add(this.listBoxAvailableProduct);
            this.Name = "FormMain";
            this.Text = "FormCheckBuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableProduct;
        private System.Windows.Forms.ListBox listBoxCheckoutItems;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCreateCheck;
        private System.Windows.Forms.Label label1;
    }
}

