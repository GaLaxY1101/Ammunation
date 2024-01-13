namespace AmmunationForm
{
    partial class createOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createOrderForm));
            this.createOrderPanel = new System.Windows.Forms.Panel();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.shopNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shopNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contactDetailsLabel = new System.Windows.Forms.Label();
            this.createOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createOrderPanel
            // 
            this.createOrderPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createOrderPanel.Controls.Add(this.createOrderButton);
            this.createOrderPanel.Controls.Add(this.shopNumberLabel);
            this.createOrderPanel.Controls.Add(this.label1);
            this.createOrderPanel.Controls.Add(this.shopNumberTextBox);
            this.createOrderPanel.Controls.Add(this.phoneTextBox);
            this.createOrderPanel.Controls.Add(this.phoneLabel);
            this.createOrderPanel.Controls.Add(this.nameTextBox);
            this.createOrderPanel.Controls.Add(this.nameLabel);
            this.createOrderPanel.Controls.Add(this.contactDetailsLabel);
            this.createOrderPanel.Location = new System.Drawing.Point(82, 12);
            this.createOrderPanel.Name = "createOrderPanel";
            this.createOrderPanel.Size = new System.Drawing.Size(793, 476);
            this.createOrderPanel.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.createOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createOrderButton.Location = new System.Drawing.Point(30, 392);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(133, 37);
            this.createOrderButton.TabIndex = 9;
            this.createOrderButton.Text = "Create order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // shopNumberLabel
            // 
            this.shopNumberLabel.AutoSize = true;
            this.shopNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shopNumberLabel.Location = new System.Drawing.Point(16, 292);
            this.shopNumberLabel.Name = "shopNumberLabel";
            this.shopNumberLabel.Size = new System.Drawing.Size(197, 38);
            this.shopNumberLabel.TabIndex = 8;
            this.shopNumberLabel.Text = "Shop number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a № of the shop where you want to get order:";
            // 
            // shopNumberTextBox
            // 
            this.shopNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopNumberTextBox.Location = new System.Drawing.Point(215, 296);
            this.shopNumberTextBox.Name = "shopNumberTextBox";
            this.shopNumberTextBox.Size = new System.Drawing.Size(183, 34);
            this.shopNumberTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTextBox.Location = new System.Drawing.Point(122, 165);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(183, 34);
            this.phoneTextBox.TabIndex = 4;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(16, 160);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(104, 38);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(122, 113);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 34);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(16, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 38);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // contactDetailsLabel
            // 
            this.contactDetailsLabel.AutoSize = true;
            this.contactDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactDetailsLabel.Location = new System.Drawing.Point(16, 51);
            this.contactDetailsLabel.Name = "contactDetailsLabel";
            this.contactDetailsLabel.Size = new System.Drawing.Size(361, 38);
            this.contactDetailsLabel.TabIndex = 0;
            this.contactDetailsLabel.Text = "Enter your contact details:";
            // 
            // createOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 533);
            this.Controls.Add(this.createOrderPanel);
            this.Name = "createOrderForm";
            this.Text = "createOrderForm";
           
            this.createOrderPanel.ResumeLayout(false);
            this.createOrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel createOrderPanel;
        private Label contactDetailsLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label shopNumberLabel;
        private Label label1;
        private TextBox shopNumberTextBox;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private Button createOrderButton;
    }
}