namespace CashierApplication
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TotalAmount = new Label();
            label6 = new Label();
            Change = new Label();
            txtItemname = new TextBox();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            txtPyament = new TextBox();
            Compute = new Button();
            Submit = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 23);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 2;
            label3.Text = "Discount(%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, 89);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAmount.Location = new Point(41, 147);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(101, 18);
            TotalAmount.TabIndex = 4;
            TotalAmount.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(130, 18);
            label6.TabIndex = 5;
            label6.Text = "Payment received:";
            // 
            // Change
            // 
            Change.AutoSize = true;
            Change.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Change.Location = new Point(80, 226);
            Change.Name = "Change";
            Change.Size = new Size(62, 18);
            Change.TabIndex = 6;
            Change.Text = "Change:";
            // 
            // txtItemname
            // 
            txtItemname.Location = new Point(12, 55);
            txtItemname.Name = "txtItemname";
            txtItemname.Size = new Size(224, 23);
            txtItemname.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(63, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(239, 55);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(154, 23);
            txtDiscount.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(316, 84);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(80, 23);
            txtQuantity.TabIndex = 10;
            // 
            // txtPyament
            // 
            txtPyament.Location = new Point(142, 189);
            txtPyament.Name = "txtPyament";
            txtPyament.Size = new Size(143, 23);
            txtPyament.TabIndex = 11;
            // 
            // Compute
            // 
            Compute.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Compute.Location = new Point(161, 113);
            Compute.Name = "Compute";
            Compute.Size = new Size(75, 31);
            Compute.TabIndex = 12;
            Compute.Text = "Compute";
            Compute.UseVisualStyleBackColor = true;
            Compute.Click += Compute_Click;
            // 
            // Submit
            // 
            Submit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.Location = new Point(291, 189);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 24);
            Submit.TabIndex = 13;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(424, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(157, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(157, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 280);
            Controls.Add(Submit);
            Controls.Add(Compute);
            Controls.Add(txtPyament);
            Controls.Add(txtQuantity);
            Controls.Add(txtDiscount);
            Controls.Add(txtPrice);
            Controls.Add(txtItemname);
            Controls.Add(Change);
            Controls.Add(label6);
            Controls.Add(TotalAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label TotalAmount;
        private Label label6;
        private Label Change;
        private TextBox txtItemname;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private TextBox txtPyament;
        private Button Compute;
        private Button Submit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}
