

namespace AmmunationForm
{
    partial class startPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPageForm));
            this.startPanel = new System.Windows.Forms.Panel();
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.searchedWeaponsDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseTypeOfWeaponComboBox = new System.Windows.Forms.ComboBox();
            this.searchWeaponTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ordersListButton = new System.Windows.Forms.Button();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedWeaponsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startPanel.Controls.Add(this.ordersListButton);
            this.startPanel.Controls.Add(this.shoppingCartButton);
            this.startPanel.Controls.Add(this.searchedWeaponsDataGridView);
            this.startPanel.Controls.Add(this.chooseTypeOfWeaponComboBox);
            this.startPanel.Controls.Add(this.searchWeaponTextBox);
            this.startPanel.Controls.Add(this.searchButton);
            this.startPanel.Location = new System.Drawing.Point(120, 67);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1048, 730);
            this.startPanel.TabIndex = 0;
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shoppingCartButton.BackgroundImage")));
            this.shoppingCartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shoppingCartButton.Location = new System.Drawing.Point(843, 13);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(53, 46);
            this.shoppingCartButton.TabIndex = 5;
            this.shoppingCartButton.UseVisualStyleBackColor = true;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // searchedWeaponsDataGridView
            // 
            this.searchedWeaponsDataGridView.AllowUserToAddRows = false;
            this.searchedWeaponsDataGridView.AllowUserToDeleteRows = false;
            this.searchedWeaponsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchedWeaponsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedWeaponsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedWeaponsDataGridView.Location = new System.Drawing.Point(100, 190);
            this.searchedWeaponsDataGridView.Name = "searchedWeaponsDataGridView";
            this.searchedWeaponsDataGridView.ReadOnly = true;
            this.searchedWeaponsDataGridView.RowHeadersWidth = 51;
            this.searchedWeaponsDataGridView.RowTemplate.Height = 29;
            this.searchedWeaponsDataGridView.Size = new System.Drawing.Size(857, 433);
            this.searchedWeaponsDataGridView.TabIndex = 4;
            this.searchedWeaponsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchedWeaponsDataGridView_CellDoubleClick);
            // 
            // chooseTypeOfWeaponComboBox
            // 
            this.chooseTypeOfWeaponComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseTypeOfWeaponComboBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseTypeOfWeaponComboBox.FormattingEnabled = true;
            this.chooseTypeOfWeaponComboBox.Items.AddRange(new object[] {
            "Choose a type...",
            "Rifle",
            "Sniper rifle",
            "Shotgun",
            "Gun"});
            this.chooseTypeOfWeaponComboBox.Location = new System.Drawing.Point(100, 110);
            this.chooseTypeOfWeaponComboBox.Name = "chooseTypeOfWeaponComboBox";
            this.chooseTypeOfWeaponComboBox.Size = new System.Drawing.Size(181, 38);
            this.chooseTypeOfWeaponComboBox.TabIndex = 1;
            this.chooseTypeOfWeaponComboBox.Text = "Choose a type...";
            // 
            // searchWeaponTextBox
            // 
            this.searchWeaponTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchWeaponTextBox.Location = new System.Drawing.Point(298, 110);
            this.searchWeaponTextBox.Name = "searchWeaponTextBox";
            this.searchWeaponTextBox.Size = new System.Drawing.Size(598, 38);
            this.searchWeaponTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(916, 110);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(41, 38);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ordersListButton
            // 
            this.ordersListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ordersListButton.BackgroundImage")));
            this.ordersListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ordersListButton.Location = new System.Drawing.Point(775, 13);
            this.ordersListButton.Name = "ordersListButton";
            this.ordersListButton.Size = new System.Drawing.Size(53, 46);
            this.ordersListButton.TabIndex = 6;
            this.ordersListButton.UseVisualStyleBackColor = true;
            this.ordersListButton.Click += new System.EventHandler(this.ordersListButton_Click);
            // 
            // startPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1382, 867);
            this.Controls.Add(this.startPanel);
            this.Name = "startPageForm";
            this.Text = "startPageForm";
            this.Load += new System.EventHandler(this.startPageForm_Load);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedWeaponsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel startPanel;
        private TextBox searchWeaponTextBox;
        private Button searchButton;
        private ComboBox chooseTypeOfWeaponComboBox;
        private DataGridView searchedWeaponsDataGridView;
        private Button shoppingCartButton;
        private Button ordersListButton;
    }
}