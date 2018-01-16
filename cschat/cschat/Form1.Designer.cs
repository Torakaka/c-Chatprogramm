namespace cschat
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
            this.Btn_name = new System.Windows.Forms.Button();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.senden_Button = new System.Windows.Forms.Button();
            this.Nachricht_Textbox = new System.Windows.Forms.TextBox();
            this.Chatfenster_Listview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Btn_name
            // 
            this.Btn_name.BackColor = System.Drawing.Color.Transparent;
            this.Btn_name.Location = new System.Drawing.Point(159, 12);
            this.Btn_name.Name = "Btn_name";
            this.Btn_name.Size = new System.Drawing.Size(96, 23);
            this.Btn_name.TabIndex = 0;
            this.Btn_name.Text = "Namen wählen";
            this.Btn_name.UseVisualStyleBackColor = false;
            this.Btn_name.Click += new System.EventHandler(this.Btn_name_Click);
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(12, 12);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(141, 20);
            this.Name_Textbox.TabIndex = 1;
            // 
            // senden_Button
            // 
            this.senden_Button.BackColor = System.Drawing.Color.Transparent;
            this.senden_Button.Location = new System.Drawing.Point(154, 205);
            this.senden_Button.Name = "senden_Button";
            this.senden_Button.Size = new System.Drawing.Size(101, 23);
            this.senden_Button.TabIndex = 2;
            this.senden_Button.Text = "Nachricht senden";
            this.senden_Button.UseVisualStyleBackColor = false;
            // 
            // Nachricht_Textbox
            // 
            this.Nachricht_Textbox.Location = new System.Drawing.Point(12, 205);
            this.Nachricht_Textbox.Name = "Nachricht_Textbox";
            this.Nachricht_Textbox.Size = new System.Drawing.Size(141, 20);
            this.Nachricht_Textbox.TabIndex = 3;
            // 
            // Chatfenster_Listview
            // 
            this.Chatfenster_Listview.Location = new System.Drawing.Point(13, 39);
            this.Chatfenster_Listview.Name = "Chatfenster_Listview";
            this.Chatfenster_Listview.Size = new System.Drawing.Size(242, 160);
            this.Chatfenster_Listview.TabIndex = 4;
            this.Chatfenster_Listview.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(267, 240);
            this.Controls.Add(this.Chatfenster_Listview);
            this.Controls.Add(this.Nachricht_Textbox);
            this.Controls.Add(this.senden_Button);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.Btn_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_name;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Button senden_Button;
        private System.Windows.Forms.TextBox Nachricht_Textbox;
        private System.Windows.Forms.ListView Chatfenster_Listview;
    }
}

