namespace Easy_Model_Generator
{
    partial class Window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.CreateButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ModelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NormalEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.MetadataEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusStaticTextLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameStaticTextLabel = new System.Windows.Forms.Label();
            this.Line1Label = new System.Windows.Forms.Label();
            this.ModidStaticTextLabel = new System.Windows.Forms.Label();
            this.ModidTextBox = new System.Windows.Forms.TextBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.VariantsTextBox = new System.Windows.Forms.RichTextBox();
            this.VariantsStaticTextLabel = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 293);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(376, 39);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create Models";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModelMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(400, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ModelMenu
            // 
            this.ModelMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NormalEntry,
            this.MetadataEntry});
            this.ModelMenu.Name = "ModelMenu";
            this.ModelMenu.Size = new System.Drawing.Size(58, 20);
            this.ModelMenu.Text = "Models";
            // 
            // NormalEntry
            // 
            this.NormalEntry.Name = "NormalEntry";
            this.NormalEntry.Size = new System.Drawing.Size(156, 22);
            this.NormalEntry.Text = "Block Normal";
            this.NormalEntry.Click += new System.EventHandler(this.NormalEntry_Click);
            // 
            // MetadataEntry
            // 
            this.MetadataEntry.Name = "MetadataEntry";
            this.MetadataEntry.Size = new System.Drawing.Size(156, 22);
            this.MetadataEntry.Text = "Block Metadata";
            this.MetadataEntry.Click += new System.EventHandler(this.MetadataEntry_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(304, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(33, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "None";
            // 
            // StatusStaticTextLabel
            // 
            this.StatusStaticTextLabel.AutoSize = true;
            this.StatusStaticTextLabel.Location = new System.Drawing.Point(225, 9);
            this.StatusStaticTextLabel.Name = "StatusStaticTextLabel";
            this.StatusStaticTextLabel.Size = new System.Drawing.Size(82, 13);
            this.StatusStaticTextLabel.TabIndex = 3;
            this.StatusStaticTextLabel.Text = "Creation Mode :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(100, 95);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(181, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameStaticTextLabel
            // 
            this.NameStaticTextLabel.AutoSize = true;
            this.NameStaticTextLabel.Location = new System.Drawing.Point(12, 98);
            this.NameStaticTextLabel.Name = "NameStaticTextLabel";
            this.NameStaticTextLabel.Size = new System.Drawing.Size(82, 13);
            this.NameStaticTextLabel.TabIndex = 5;
            this.NameStaticTextLabel.Text = "Registry Name :";
            // 
            // Line1Label
            // 
            this.Line1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line1Label.Location = new System.Drawing.Point(15, 38);
            this.Line1Label.Name = "Line1Label";
            this.Line1Label.Size = new System.Drawing.Size(373, 2);
            this.Line1Label.TabIndex = 7;
            // 
            // ModidStaticTextLabel
            // 
            this.ModidStaticTextLabel.AutoSize = true;
            this.ModidStaticTextLabel.Location = new System.Drawing.Point(12, 62);
            this.ModidStaticTextLabel.Name = "ModidStaticTextLabel";
            this.ModidStaticTextLabel.Size = new System.Drawing.Size(42, 13);
            this.ModidStaticTextLabel.TabIndex = 9;
            this.ModidStaticTextLabel.Text = "Modid :";
            // 
            // ModidTextBox
            // 
            this.ModidTextBox.Location = new System.Drawing.Point(100, 59);
            this.ModidTextBox.Name = "ModidTextBox";
            this.ModidTextBox.Size = new System.Drawing.Size(181, 20);
            this.ModidTextBox.TabIndex = 1;
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Easy_Model_Generator.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(298, 52);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(86, 82);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 6;
            this.LogoPicture.TabStop = false;
            this.LogoPicture.Click += new System.EventHandler(this.LogoPicture_Click);
            // 
            // VariantsTextBox
            // 
            this.VariantsTextBox.Enabled = false;
            this.VariantsTextBox.Location = new System.Drawing.Point(100, 132);
            this.VariantsTextBox.Name = "VariantsTextBox";
            this.VariantsTextBox.Size = new System.Drawing.Size(181, 146);
            this.VariantsTextBox.TabIndex = 3;
            this.VariantsTextBox.Text = "";
            // 
            // VariantsStaticTextLabel
            // 
            this.VariantsStaticTextLabel.AutoSize = true;
            this.VariantsStaticTextLabel.Enabled = false;
            this.VariantsStaticTextLabel.Location = new System.Drawing.Point(12, 135);
            this.VariantsStaticTextLabel.Name = "VariantsStaticTextLabel";
            this.VariantsStaticTextLabel.Size = new System.Drawing.Size(51, 13);
            this.VariantsStaticTextLabel.TabIndex = 11;
            this.VariantsStaticTextLabel.Text = "Variants :";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 344);
            this.Controls.Add(this.VariantsStaticTextLabel);
            this.Controls.Add(this.VariantsTextBox);
            this.Controls.Add(this.ModidStaticTextLabel);
            this.Controls.Add(this.ModidTextBox);
            this.Controls.Add(this.Line1Label);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.NameStaticTextLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.StatusStaticTextLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Model Creator";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ModelMenu;
        private System.Windows.Forms.ToolStripMenuItem NormalEntry;
        private System.Windows.Forms.ToolStripMenuItem MetadataEntry;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusStaticTextLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameStaticTextLabel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label Line1Label;
        private System.Windows.Forms.Label ModidStaticTextLabel;
        private System.Windows.Forms.TextBox ModidTextBox;
        private System.Windows.Forms.RichTextBox VariantsTextBox;
        private System.Windows.Forms.Label VariantsStaticTextLabel;
    }
}

