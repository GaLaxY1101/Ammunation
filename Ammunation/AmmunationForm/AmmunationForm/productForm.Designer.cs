namespace AmmunationForm
{
    partial class productForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productForm));
            this.productPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.productNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToTheCartButton = new System.Windows.Forms.Button();
            this.uniqueValueLabel = new System.Windows.Forms.Label();
            this.uniqueLabel = new System.Windows.Forms.Label();
            this.massValueLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.barrelLengthValueLable = new System.Windows.Forms.Label();
            this.barrelLengthLabel = new System.Windows.Forms.Label();
            this.storeCapacityValueLabel = new System.Windows.Forms.Label();
            this.storeCapacityLabel = new System.Windows.Forms.Label();
            this.caliberValueLabel = new System.Windows.Forms.Label();
            this.caliberLabel = new System.Windows.Forms.Label();
            this.typeValueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.purposeValueLabel = new System.Windows.Forms.Label();
            this.purposeLabel = new System.Windows.Forms.Label();
            this.countryValueLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.brandValueLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.titleValueLable = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productPanel.Controls.Add(this.backButton);
            this.productPanel.Controls.Add(this.priceLabel);
            this.productPanel.Controls.Add(this.priceValueLabel);
            this.productPanel.Controls.Add(this.productNumericUpDown);
            this.productPanel.Controls.Add(this.addToTheCartButton);
            this.productPanel.Controls.Add(this.uniqueValueLabel);
            this.productPanel.Controls.Add(this.uniqueLabel);
            this.productPanel.Controls.Add(this.massValueLabel);
            this.productPanel.Controls.Add(this.massLabel);
            this.productPanel.Controls.Add(this.barrelLengthValueLable);
            this.productPanel.Controls.Add(this.barrelLengthLabel);
            this.productPanel.Controls.Add(this.storeCapacityValueLabel);
            this.productPanel.Controls.Add(this.storeCapacityLabel);
            this.productPanel.Controls.Add(this.caliberValueLabel);
            this.productPanel.Controls.Add(this.caliberLabel);
            this.productPanel.Controls.Add(this.typeValueLabel);
            this.productPanel.Controls.Add(this.typeLabel);
            this.productPanel.Controls.Add(this.purposeValueLabel);
            this.productPanel.Controls.Add(this.purposeLabel);
            this.productPanel.Controls.Add(this.countryValueLabel);
            this.productPanel.Controls.Add(this.countryLabel);
            this.productPanel.Controls.Add(this.brandValueLabel);
            this.productPanel.Controls.Add(this.brandLabel);
            this.productPanel.Controls.Add(this.titleValueLable);
            this.productPanel.Controls.Add(this.titleLabel);
            this.productPanel.Location = new System.Drawing.Point(232, 12);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(557, 518);
            this.productPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(35, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(79, 45);
            this.backButton.TabIndex = 26;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(33, 461);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 38);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Price:";
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceValueLabel.Location = new System.Drawing.Point(118, 461);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(87, 38);
            this.priceValueLabel.TabIndex = 24;
            this.priceValueLabel.Text = "value";
            // 
            // productNumericUpDown
            // 
            this.productNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNumericUpDown.Location = new System.Drawing.Point(475, 468);
            this.productNumericUpDown.Name = "productNumericUpDown";
            this.productNumericUpDown.Size = new System.Drawing.Size(40, 34);
            this.productNumericUpDown.TabIndex = 23;
            // 
            // addToTheCartButton
            // 
            this.addToTheCartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addToTheCartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToTheCartButton.Location = new System.Drawing.Point(375, 466);
            this.addToTheCartButton.Name = "addToTheCartButton";
            this.addToTheCartButton.Size = new System.Drawing.Size(94, 38);
            this.addToTheCartButton.TabIndex = 22;
            this.addToTheCartButton.Text = "add to cart";
            this.addToTheCartButton.UseVisualStyleBackColor = false;
            this.addToTheCartButton.Click += new System.EventHandler(this.addToTheCartButton_Click);
            // 
            // uniqueValueLabel
            // 
            this.uniqueValueLabel.AutoSize = true;
            this.uniqueValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uniqueValueLabel.Location = new System.Drawing.Point(257, 410);
            this.uniqueValueLabel.Name = "uniqueValueLabel";
            this.uniqueValueLabel.Size = new System.Drawing.Size(82, 38);
            this.uniqueValueLabel.TabIndex = 21;
            this.uniqueValueLabel.Text = "value";
            // 
            // uniqueLabel
            // 
            this.uniqueLabel.AutoSize = true;
            this.uniqueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uniqueLabel.Location = new System.Drawing.Point(35, 410);
            this.uniqueLabel.Name = "uniqueLabel";
            this.uniqueLabel.Size = new System.Drawing.Size(115, 38);
            this.uniqueLabel.TabIndex = 20;
            this.uniqueLabel.Text = "Unique:";
            // 
            // massValueLabel
            // 
            this.massValueLabel.AutoSize = true;
            this.massValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.massValueLabel.Location = new System.Drawing.Point(257, 372);
            this.massValueLabel.Name = "massValueLabel";
            this.massValueLabel.Size = new System.Drawing.Size(82, 38);
            this.massValueLabel.TabIndex = 17;
            this.massValueLabel.Text = "value";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.massLabel.Location = new System.Drawing.Point(35, 372);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(89, 38);
            this.massLabel.TabIndex = 16;
            this.massLabel.Text = "Mass:";
            // 
            // barrelLengthValueLable
            // 
            this.barrelLengthValueLable.AutoSize = true;
            this.barrelLengthValueLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barrelLengthValueLable.Location = new System.Drawing.Point(257, 334);
            this.barrelLengthValueLable.Name = "barrelLengthValueLable";
            this.barrelLengthValueLable.Size = new System.Drawing.Size(82, 38);
            this.barrelLengthValueLable.TabIndex = 15;
            this.barrelLengthValueLable.Text = "value";
            // 
            // barrelLengthLabel
            // 
            this.barrelLengthLabel.AutoSize = true;
            this.barrelLengthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barrelLengthLabel.Location = new System.Drawing.Point(35, 334);
            this.barrelLengthLabel.Name = "barrelLengthLabel";
            this.barrelLengthLabel.Size = new System.Drawing.Size(187, 38);
            this.barrelLengthLabel.TabIndex = 14;
            this.barrelLengthLabel.Text = "Barrel length:";
            // 
            // storeCapacityValueLabel
            // 
            this.storeCapacityValueLabel.AutoSize = true;
            this.storeCapacityValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeCapacityValueLabel.Location = new System.Drawing.Point(257, 296);
            this.storeCapacityValueLabel.Name = "storeCapacityValueLabel";
            this.storeCapacityValueLabel.Size = new System.Drawing.Size(82, 38);
            this.storeCapacityValueLabel.TabIndex = 13;
            this.storeCapacityValueLabel.Text = "value";
            // 
            // storeCapacityLabel
            // 
            this.storeCapacityLabel.AutoSize = true;
            this.storeCapacityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeCapacityLabel.Location = new System.Drawing.Point(35, 296);
            this.storeCapacityLabel.Name = "storeCapacityLabel";
            this.storeCapacityLabel.Size = new System.Drawing.Size(202, 38);
            this.storeCapacityLabel.TabIndex = 12;
            this.storeCapacityLabel.Text = "Store capacity:";
            // 
            // caliberValueLabel
            // 
            this.caliberValueLabel.AutoSize = true;
            this.caliberValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caliberValueLabel.Location = new System.Drawing.Point(257, 258);
            this.caliberValueLabel.Name = "caliberValueLabel";
            this.caliberValueLabel.Size = new System.Drawing.Size(82, 38);
            this.caliberValueLabel.TabIndex = 11;
            this.caliberValueLabel.Text = "value";
            // 
            // caliberLabel
            // 
            this.caliberLabel.AutoSize = true;
            this.caliberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caliberLabel.Location = new System.Drawing.Point(35, 258);
            this.caliberLabel.Name = "caliberLabel";
            this.caliberLabel.Size = new System.Drawing.Size(113, 38);
            this.caliberLabel.TabIndex = 10;
            this.caliberLabel.Text = "Caliber:";
            // 
            // typeValueLabel
            // 
            this.typeValueLabel.AutoSize = true;
            this.typeValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeValueLabel.Location = new System.Drawing.Point(257, 217);
            this.typeValueLabel.Name = "typeValueLabel";
            this.typeValueLabel.Size = new System.Drawing.Size(82, 38);
            this.typeValueLabel.TabIndex = 9;
            this.typeValueLabel.Text = "value";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.Location = new System.Drawing.Point(35, 217);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(84, 38);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type:";
            // 
            // purposeValueLabel
            // 
            this.purposeValueLabel.AutoSize = true;
            this.purposeValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purposeValueLabel.Location = new System.Drawing.Point(257, 179);
            this.purposeValueLabel.Name = "purposeValueLabel";
            this.purposeValueLabel.Size = new System.Drawing.Size(82, 38);
            this.purposeValueLabel.TabIndex = 7;
            this.purposeValueLabel.Text = "value";
            // 
            // purposeLabel
            // 
            this.purposeLabel.AutoSize = true;
            this.purposeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purposeLabel.Location = new System.Drawing.Point(34, 179);
            this.purposeLabel.Name = "purposeLabel";
            this.purposeLabel.Size = new System.Drawing.Size(127, 38);
            this.purposeLabel.TabIndex = 6;
            this.purposeLabel.Text = "Purpose:";
            // 
            // countryValueLabel
            // 
            this.countryValueLabel.AutoSize = true;
            this.countryValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryValueLabel.Location = new System.Drawing.Point(257, 141);
            this.countryValueLabel.Name = "countryValueLabel";
            this.countryValueLabel.Size = new System.Drawing.Size(82, 38);
            this.countryValueLabel.TabIndex = 5;
            this.countryValueLabel.Text = "value";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(34, 141);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(125, 38);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country:";
            // 
            // brandValueLabel
            // 
            this.brandValueLabel.AutoSize = true;
            this.brandValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandValueLabel.Location = new System.Drawing.Point(257, 103);
            this.brandValueLabel.Name = "brandValueLabel";
            this.brandValueLabel.Size = new System.Drawing.Size(82, 38);
            this.brandValueLabel.TabIndex = 3;
            this.brandValueLabel.Text = "value";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brandLabel.Location = new System.Drawing.Point(34, 103);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(99, 38);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand:";
            // 
            // titleValueLable
            // 
            this.titleValueLable.AutoSize = true;
            this.titleValueLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleValueLable.Location = new System.Drawing.Point(257, 65);
            this.titleValueLable.Name = "titleValueLable";
            this.titleValueLable.Size = new System.Drawing.Size(82, 38);
            this.titleValueLable.TabIndex = 1;
            this.titleValueLable.Text = "value";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(34, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Name:";
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 621);
            this.Controls.Add(this.productPanel);
            this.Name = "productForm";
            this.Text = "productForm";
            this.Activated += new System.EventHandler(this.productForm_Activated);
            this.Load += new System.EventHandler(this.productForm_Load);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel productPanel;
        private Label massValueLabel;
        private Label massLabel;
        private Label barrelLengthValueLable;
        private Label barrelLengthLabel;
        private Label storeCapacityValueLabel;
        private Label storeCapacityLabel;
        private Label caliberValueLabel;
        private Label caliberLabel;
        private Label typeValueLabel;
        private Label typeLabel;
        private Label purposeValueLabel;
        private Label purposeLabel;
        private Label countryValueLabel;
        private Label countryLabel;
        private Label brandValueLabel;
        private Label brandLabel;
        private Label titleValueLable;
        private Label titleLabel;
        private Label uniqueValueLabel;
        private Label uniqueLabel;
        private Button addToTheCartButton;
        private NumericUpDown productNumericUpDown;
        private Label priceValueLabel;
        private Label priceLabel;
        private Button backButton;
    }
}