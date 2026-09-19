namespace KeresztrejtvenyGUI
{
    partial class Form1
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
            this.sor = new System.Windows.Forms.ComboBox();
            this.oszlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.letrehozasButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sor
            // 
            this.sor.FormattingEnabled = true;
            this.sor.Location = new System.Drawing.Point(199, 35);
            this.sor.Name = "sor";
            this.sor.Size = new System.Drawing.Size(55, 21);
            this.sor.TabIndex = 0;
            // 
            // oszlop
            // 
            this.oszlop.FormattingEnabled = true;
            this.oszlop.Location = new System.Drawing.Point(260, 35);
            this.oszlop.Name = "oszlop";
            this.oszlop.Size = new System.Drawing.Size(55, 21);
            this.oszlop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresztrejtvény mérete [sor x oszlop]:";
            // 
            // letrehozasButton
            // 
            this.letrehozasButton.Location = new System.Drawing.Point(12, 77);
            this.letrehozasButton.Name = "letrehozasButton";
            this.letrehozasButton.Size = new System.Drawing.Size(142, 23);
            this.letrehozasButton.TabIndex = 3;
            this.letrehozasButton.Text = "Keresztrejtvény létrehozás";
            this.letrehozasButton.UseVisualStyleBackColor = true;
            this.letrehozasButton.Click += new System.EventHandler(this.letrehozasButton_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(160, 77);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(142, 23);
            this.mentesButton.TabIndex = 4;
            this.mentesButton.Text = "Keresztrejtvény mentése";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // index
            // 
            this.index.FormattingEnabled = true;
            this.index.Location = new System.Drawing.Point(308, 79);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(55, 21);
            this.index.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.index);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.letrehozasButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oszlop);
            this.Controls.Add(this.sor);
            this.Name = "Form1";
            this.Text = "Keresztrejtvény készítő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sor;
        private System.Windows.Forms.ComboBox oszlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button letrehozasButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.ComboBox index;
    }
}

