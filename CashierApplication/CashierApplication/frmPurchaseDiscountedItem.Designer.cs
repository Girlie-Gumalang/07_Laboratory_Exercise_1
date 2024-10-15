namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtItem = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            btnCompute = new Button();
            lblTotalAmount = new Label();
            label6 = new Label();
            txtPaymentReceived = new TextBox();
            btnSubmit = new Button();
            lblChange = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txtItem
            // 
            txtItem.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItem.Location = new Point(12, 48);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(267, 31);
            txtItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(85, 85);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(194, 31);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 20);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 4;
            label3.Text = "Discount (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(297, 48);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(178, 31);
            txtDiscount.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 91);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(392, 88);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(83, 31);
            txtQuantity.TabIndex = 7;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Silver;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(192, 133);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(102, 35);
            btnCompute.TabIndex = 8;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(58, 194);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(143, 25);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 254);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 10;
            label6.Text = "Payment received:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentReceived.Location = new Point(219, 254);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(146, 31);
            txtPaymentReceived.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Silver;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(371, 254);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(88, 31);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(108, 313);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(93, 25);
            lblChange.TabIndex = 13;
            lblChange.Text = "Change:";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(490, 450);
            Controls.Add(lblChange);
            Controls.Add(btnSubmit);
            Controls.Add(txtPaymentReceived);
            Controls.Add(label6);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnCompute);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtDiscount);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtItem);
            Controls.Add(label1);
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItem;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtDiscount;
        private Label label4;
        private TextBox txtQuantity;
        private Button btnCompute;
        private Label lblTotalAmount;
        private Label label6;
        private TextBox txtPaymentReceived;
        private Button btnSubmit;
        private Label lblChange;
    }
}
