
namespace Adressbok
{
    partial class frmAdressbok
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
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelPostort = new System.Windows.Forms.Label();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxPostort = new System.Windows.Forms.TextBox();
            this.buttonAndra = new System.Windows.Forms.Button();
            this.buttonTabort = new System.Windows.Forms.Button();
            this.buttonSok = new System.Windows.Forms.Button();
            this.buttonSkapa = new System.Windows.Forms.Button();
            this.buttonRensa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listAdress = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(28, 97);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(79, 32);
            this.labelNamn.TabIndex = 0;
            this.labelNamn.Text = "Namn";
            // 
            // labelPostort
            // 
            this.labelPostort.AutoSize = true;
            this.labelPostort.Location = new System.Drawing.Point(28, 181);
            this.labelPostort.Name = "labelPostort";
            this.labelPostort.Size = new System.Drawing.Size(88, 32);
            this.labelPostort.TabIndex = 3;
            this.labelPostort.Text = "Postort";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(133, 97);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(809, 39);
            this.textBoxNamn.TabIndex = 6;
            // 
            // textBoxPostort
            // 
            this.textBoxPostort.Location = new System.Drawing.Point(133, 174);
            this.textBoxPostort.Name = "textBoxPostort";
            this.textBoxPostort.Size = new System.Drawing.Size(809, 39);
            this.textBoxPostort.TabIndex = 9;
            // 
            // buttonAndra
            // 
            this.buttonAndra.Location = new System.Drawing.Point(33, 930);
            this.buttonAndra.Name = "buttonAndra";
            this.buttonAndra.Size = new System.Drawing.Size(150, 46);
            this.buttonAndra.TabIndex = 12;
            this.buttonAndra.Text = "Ändra";
            this.buttonAndra.UseVisualStyleBackColor = true;
            this.buttonAndra.Click += new System.EventHandler(this.buttonAndra_Click);
            // 
            // buttonTabort
            // 
            this.buttonTabort.Location = new System.Drawing.Point(225, 930);
            this.buttonTabort.Name = "buttonTabort";
            this.buttonTabort.Size = new System.Drawing.Size(150, 46);
            this.buttonTabort.TabIndex = 13;
            this.buttonTabort.Text = "Ta bort";
            this.buttonTabort.UseVisualStyleBackColor = true;
            this.buttonTabort.Click += new System.EventHandler(this.buttonTabort_Click);
            // 
            // buttonSok
            // 
            this.buttonSok.Location = new System.Drawing.Point(786, 247);
            this.buttonSok.Name = "buttonSok";
            this.buttonSok.Size = new System.Drawing.Size(156, 46);
            this.buttonSok.TabIndex = 15;
            this.buttonSok.Text = "Sök";
            this.buttonSok.UseVisualStyleBackColor = true;
            this.buttonSok.Click += new System.EventHandler(this.buttonSok_Click);
            // 
            // buttonSkapa
            // 
            this.buttonSkapa.Location = new System.Drawing.Point(717, 930);
            this.buttonSkapa.Name = "buttonSkapa";
            this.buttonSkapa.Size = new System.Drawing.Size(225, 46);
            this.buttonSkapa.TabIndex = 16;
            this.buttonSkapa.Text = "Skapa ny kontakt";
            this.buttonSkapa.UseVisualStyleBackColor = true;
            this.buttonSkapa.Click += new System.EventHandler(this.buttonSkapa_Click);
            // 
            // buttonRensa
            // 
            this.buttonRensa.Location = new System.Drawing.Point(607, 247);
            this.buttonRensa.Name = "buttonRensa";
            this.buttonRensa.Size = new System.Drawing.Size(150, 46);
            this.buttonRensa.TabIndex = 17;
            this.buttonRensa.Text = "Rensa";
            this.buttonRensa.UseVisualStyleBackColor = true;
            this.buttonRensa.Click += new System.EventHandler(this.buttonRensa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Levents Adressbok";
            // 
            // listAdress
            // 
            this.listAdress.FormattingEnabled = true;
            this.listAdress.ItemHeight = 32;
            this.listAdress.Location = new System.Drawing.Point(28, 315);
            this.listAdress.Name = "listAdress";
            this.listAdress.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listAdress.Size = new System.Drawing.Size(914, 580);
            this.listAdress.TabIndex = 19;
            // 
            // frmAdressbok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 1051);
            this.Controls.Add(this.listAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRensa);
            this.Controls.Add(this.buttonSkapa);
            this.Controls.Add(this.buttonSok);
            this.Controls.Add(this.buttonTabort);
            this.Controls.Add(this.buttonAndra);
            this.Controls.Add(this.textBoxPostort);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.labelPostort);
            this.Controls.Add(this.labelNamn);
            this.Name = "frmAdressbok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adressbok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelPostort;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxPostort;
        private System.Windows.Forms.Button buttonAndra;
        private System.Windows.Forms.Button buttonTabort;
        private System.Windows.Forms.Button buttonSok;
        private System.Windows.Forms.Button buttonSkapa;
        private System.Windows.Forms.Button buttonRensa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listAdress;
    }
}

