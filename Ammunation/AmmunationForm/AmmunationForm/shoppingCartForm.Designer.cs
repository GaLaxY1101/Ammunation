using Ammunation_console;

namespace AmmunationForm
{
    partial class shoppingCartForm
    {
        public ShoppingCart MyShoppingCart { get; set; }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shoppingCartForm));
            this.shoppingCartPanel = new System.Windows.Forms.Panel();
            this.toOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartDataGridView1 = new System.Windows.Forms.DataGridView();
            this.shoppingCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartPanel
            // 
            this.shoppingCartPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoppingCartPanel.Controls.Add(this.toOrderButton);
            this.shoppingCartPanel.Controls.Add(this.backButton);
            this.shoppingCartPanel.Controls.Add(this.totalPriceLabel);
            this.shoppingCartPanel.Controls.Add(this.shoppingCartLabel);
            this.shoppingCartPanel.Controls.Add(this.shoppingCartDataGridView1);
            this.shoppingCartPanel.Location = new System.Drawing.Point(159, -4);
            this.shoppingCartPanel.Name = "shoppingCartPanel";
            this.shoppingCartPanel.Size = new System.Drawing.Size(650, 611);
            this.shoppingCartPanel.TabIndex = 0;
            // 
            // toOrderButton
            // 
            this.toOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.toOrderButton.ForeColor = System.Drawing.Color.White;
            this.toOrderButton.Location = new System.Drawing.Point(106, 490);
            this.toOrderButton.Name = "toOrderButton";
            this.toOrderButton.Size = new System.Drawing.Size(138, 40);
            this.toOrderButton.TabIndex = 4;
            this.toOrderButton.Text = "To order";
            this.toOrderButton.UseVisualStyleBackColor = false;
            this.toOrderButton.Click += new System.EventHandler(this.toOrderButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(10, 16);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 43);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(94, 438);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(161, 38);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total price:";
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingCartLabel.Location = new System.Drawing.Point(94, 51);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(218, 41);
            this.shoppingCartLabel.TabIndex = 1;
            this.shoppingCartLabel.Text = "Shopping cart";
            // 
            // shoppingCartDataGridView1
            // 
            this.shoppingCartDataGridView1.AllowUserToAddRows = false;
            this.shoppingCartDataGridView1.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoppingCartDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shoppingCartDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoppingCartDataGridView1.Location = new System.Drawing.Point(94, 103);
            this.shoppingCartDataGridView1.Name = "shoppingCartDataGridView1";
            this.shoppingCartDataGridView1.ReadOnly = true;
            this.shoppingCartDataGridView1.RowHeadersWidth = 51;
            this.shoppingCartDataGridView1.RowTemplate.Height = 29;
            this.shoppingCartDataGridView1.Size = new System.Drawing.Size(299, 331);
            this.shoppingCartDataGridView1.TabIndex = 0;
            // 
            // shoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 660);
            this.Controls.Add(this.shoppingCartPanel);
            this.Name = "shoppingCartForm";
            this.Text = "shoppingCartForm";
            this.Activated += new System.EventHandler(this.shoppingCartForm_Activated);
            this.Load += new System.EventHandler(this.shoppingCartForm_Load);
            this.shoppingCartPanel.ResumeLayout(false);
            this.shoppingCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel shoppingCartPanel;
        private Label shoppingCartLabel;
        private DataGridView shoppingCartDataGridView1;
        private Label totalPriceLabel;
        private Button backButton;
        private Button toOrderButton;
    }
}