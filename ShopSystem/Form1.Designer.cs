namespace ShopSystem
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Refund = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.Count = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Guarantee = new System.Windows.Forms.ColumnHeader();
            this.IsArchive = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.Refund);
            this.splitContainer1.Panel1.Controls.Add(this.Accept);
            this.splitContainer1.Panel1.Controls.Add(this.Sell);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductList);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // Refund
            // 
            this.Refund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Refund.AutoSize = true;
            this.Refund.BackColor = System.Drawing.Color.Tomato;
            this.Refund.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refund.Location = new System.Drawing.Point(12, 120);
            this.Refund.Margin = new System.Windows.Forms.Padding(0);
            this.Refund.Name = "Refund";
            this.Refund.Size = new System.Drawing.Size(191, 48);
            this.Refund.TabIndex = 2;
            this.Refund.Text = "Возврат";
            this.Refund.UseVisualStyleBackColor = false;
            // 
            // Accept
            // 
            this.Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept.AutoSize = true;
            this.Accept.BackColor = System.Drawing.Color.Gold;
            this.Accept.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Accept.Location = new System.Drawing.Point(12, 66);
            this.Accept.Margin = new System.Windows.Forms.Padding(0);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(191, 48);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = false;
            // 
            // Sell
            // 
            this.Sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sell.AutoSize = true;
            this.Sell.BackColor = System.Drawing.Color.OliveDrab;
            this.Sell.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sell.Location = new System.Drawing.Point(12, 12);
            this.Sell.Margin = new System.Windows.Forms.Padding(0);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(191, 48);
            this.Sell.TabIndex = 0;
            this.Sell.Text = "Продать";
            this.Sell.UseVisualStyleBackColor = false;
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProductName,
            this.Count,
            this.Price,
            this.Guarantee,
            this.IsArchive});
            this.ProductList.Location = new System.Drawing.Point(3, 0);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(576, 450);
            this.ProductList.TabIndex = 0;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.List;
            // 
            // ID
            // 
            this.ID.Text = "Артикул";
            // 
            // ProductName
            // 
            this.ProductName.Text = "Имя";
            this.ProductName.Width = 180;
            // 
            // Count
            // 
            this.Count.Text = "Количество";
            // 
            // Price
            // 
            this.Price.Text = "Цена за единицу";
            // 
            // Guarantee
            // 
            this.Guarantee.Text = "Гарантия";
            // 
            // IsArchive
            // 
            this.IsArchive.Text = "Архивный";
            this.IsArchive.Width = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button Refund;
        private Button Accept;
        private Button Sell;
        private ListView ProductList;
        private ColumnHeader ID;
        private ColumnHeader ProductName;
        private ColumnHeader Count;
        private ColumnHeader Price;
        private ColumnHeader Guarantee;
        private ColumnHeader IsArchive;
    }
}