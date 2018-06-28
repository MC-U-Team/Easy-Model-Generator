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
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 397);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(376, 41);
            this.CreateButton.TabIndex = 0;
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
            this.NormalEntry.Size = new System.Drawing.Size(180, 22);
            this.NormalEntry.Text = "Normal";
            this.NormalEntry.Click += new System.EventHandler(this.NormalEntry_Click);
            // 
            // MetadataEntry
            // 
            this.MetadataEntry.Name = "MetadataEntry";
            this.MetadataEntry.Size = new System.Drawing.Size(180, 22);
            this.MetadataEntry.Text = "Metadata";
            this.MetadataEntry.Click += new System.EventHandler(this.MetadataEntry_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(338, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Normal";
            // 
            // StatusStaticTextLabel
            // 
            this.StatusStaticTextLabel.AutoSize = true;
            this.StatusStaticTextLabel.Location = new System.Drawing.Point(259, 9);
            this.StatusStaticTextLabel.Name = "StatusStaticTextLabel";
            this.StatusStaticTextLabel.Size = new System.Drawing.Size(82, 13);
            this.StatusStaticTextLabel.TabIndex = 3;
            this.StatusStaticTextLabel.Text = "Creation Mode :";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.StatusStaticTextLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Model Creator";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
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
    }
}

