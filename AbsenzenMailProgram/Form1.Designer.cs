namespace AbsenzenMailProgram
{
    partial class Form1
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
            this.b_newbox = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.b_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.b_sendmail = new System.Windows.Forms.Button();
            this.StatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_newbox
            // 
            this.b_newbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_newbox.Location = new System.Drawing.Point(40, 80);
            this.b_newbox.Name = "b_newbox";
            this.b_newbox.Size = new System.Drawing.Size(26, 26);
            this.b_newbox.TabIndex = 0;
            this.b_newbox.Text = "+";
            this.b_newbox.UseVisualStyleBackColor = true;
            this.b_newbox.Click += new System.EventHandler(this.b_newbox_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 305);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(319, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(10, 17);
            this.StatusLabel.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_reset,
            this.b_restart,
            this.toolStripSeparator1,
            this.b_exit});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // b_reset
            // 
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(110, 22);
            this.b_reset.Text = "Reset";
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_restart
            // 
            this.b_restart.Name = "b_restart";
            this.b_restart.Size = new System.Drawing.Size(110, 22);
            this.b_restart.Text = "Restart";
            this.b_restart.Click += new System.EventHandler(this.b_restart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // b_exit
            // 
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(110, 22);
            this.b_exit.Text = "Exit";
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_sendmail
            // 
            this.b_sendmail.Location = new System.Drawing.Point(120, 260);
            this.b_sendmail.Name = "b_sendmail";
            this.b_sendmail.Size = new System.Drawing.Size(75, 23);
            this.b_sendmail.TabIndex = 3;
            this.b_sendmail.Text = "Send Mail";
            this.b_sendmail.UseVisualStyleBackColor = true;
            this.b_sendmail.Click += new System.EventHandler(this.b_sendmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 327);
            this.Controls.Add(this.b_sendmail);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.b_newbox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_newbox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_reset;
        private System.Windows.Forms.ToolStripMenuItem b_restart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem b_exit;
        private System.Windows.Forms.Button b_sendmail;
    }
}

