
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
            this.listAdress = new System.Windows.Forms.ListView();
            this.buttonSok = new System.Windows.Forms.Button();
            this.buttonSkapa = new System.Windows.Forms.Button();
            this.buttonRensa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.textBoxNamn.Size = new System.Drawing.Size(648, 39);
            this.textBoxNamn.TabIndex = 6;
            // 
            // textBoxPostort
            // 
            this.textBoxPostort.Location = new System.Drawing.Point(133, 174);
            this.textBoxPostort.Name = "textBoxPostort";
            this.textBoxPostort.Size = new System.Drawing.Size(647, 39);
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
            // 
            // buttonTabort
            // 
            this.buttonTabort.Location = new System.Drawing.Point(225, 930);
            this.buttonTabort.Name = "buttonTabort";
            this.buttonTabort.Size = new System.Drawing.Size(150, 46);
            this.buttonTabort.TabIndex = 13;
            this.buttonTabort.Text = "Ta bort";
            this.buttonTabort.UseVisualStyleBackColor = true;
            // 
            // listAdress
            // 
            this.listAdress.HideSelection = false;
            this.listAdress.Location = new System.Drawing.Point(27, 322);
            this.listAdress.Name = "listAdress";
            this.listAdress.Size = new System.Drawing.Size(753, 570);
            this.listAdress.TabIndex = 14;
            this.listAdress.UseCompatibleStateImageBehavior = false;
            this.listAdress.SelectedIndexChanged += new System.EventHandler(this.listAdress_SelectedIndexChanged);
            // 
            // buttonSok
            // 
            this.buttonSok.Location = new System.Drawing.Point(631, 248);
            this.buttonSok.Name = "buttonSok";
            this.buttonSok.Size = new System.Drawing.Size(150, 46);
            this.buttonSok.TabIndex = 15;
            this.buttonSok.Text = "Sök";
            this.buttonSok.UseVisualStyleBackColor = true;
            // 
            // buttonSkapa
            // 
            this.buttonSkapa.Location = new System.Drawing.Point(555, 930);
            this.buttonSkapa.Name = "buttonSkapa";
            this.buttonSkapa.Size = new System.Drawing.Size(225, 46);
            this.buttonSkapa.TabIndex = 16;
            this.buttonSkapa.Text = "Skapa ny kontakt";
            this.buttonSkapa.UseVisualStyleBackColor = true;
            this.buttonSkapa.Click += new System.EventHandler(this.buttonSkapa_Click);
            // 
            // buttonRensa
            // 
            this.buttonRensa.Location = new System.Drawing.Point(452, 248);
            this.buttonRensa.Name = "buttonRensa";
            this.buttonRensa.Size = new System.Drawing.Size(150, 46);
            this.buttonRensa.TabIndex = 17;
            this.buttonRensa.Text = "Rensa";
            this.buttonRensa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adressbok";
            // 
            // frmAdressbok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 1068);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRensa);
            this.Controls.Add(this.buttonSkapa);
            this.Controls.Add(this.buttonSok);
            this.Controls.Add(this.listAdress);
            this.Controls.Add(this.buttonTabort);
            this.Controls.Add(this.buttonAndra);
            this.Controls.Add(this.textBoxPostort);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.labelPostort);
            this.Controls.Add(this.labelNamn);
            this.Name = "frmAdressbok";
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
        private System.Windows.Forms.ListView listAdress;
        private System.Windows.Forms.Button buttonSok;
        private System.Windows.Forms.Button buttonSkapa;
        private System.Windows.Forms.Button buttonRensa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

