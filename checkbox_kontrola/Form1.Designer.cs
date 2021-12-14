
namespace checkbox_kontrola
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
            this.dorucak = new System.Windows.Forms.CheckBox();
            this.rucak = new System.Windows.Forms.CheckBox();
            this.vecera = new System.Windows.Forms.CheckBox();
            this.sakrij = new System.Windows.Forms.CheckBox();
            this.Posalji = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dorucak
            // 
            this.dorucak.AutoSize = true;
            this.dorucak.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dorucak.Location = new System.Drawing.Point(76, 43);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(163, 49);
            this.dorucak.TabIndex = 0;
            this.dorucak.Text = "Dorucak";
            this.dorucak.UseVisualStyleBackColor = true;
            // 
            // rucak
            // 
            this.rucak.AutoSize = true;
            this.rucak.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rucak.Location = new System.Drawing.Point(76, 98);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(131, 49);
            this.rucak.TabIndex = 1;
            this.rucak.Text = "Rucak";
            this.rucak.UseVisualStyleBackColor = true;
            // 
            // vecera
            // 
            this.vecera.AutoSize = true;
            this.vecera.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vecera.Location = new System.Drawing.Point(76, 158);
            this.vecera.Name = "vecera";
            this.vecera.Size = new System.Drawing.Size(142, 49);
            this.vecera.TabIndex = 2;
            this.vecera.Text = "Vecera";
            this.vecera.UseVisualStyleBackColor = true;
            // 
            // sakrij
            // 
            this.sakrij.AutoSize = true;
            this.sakrij.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sakrij.Location = new System.Drawing.Point(294, 255);
            this.sakrij.Name = "sakrij";
            this.sakrij.Size = new System.Drawing.Size(285, 49);
            this.sakrij.TabIndex = 3;
            this.sakrij.Text = "Sakrij narudžbu";
            this.sakrij.UseVisualStyleBackColor = true;
            this.sakrij.CheckedChanged += new System.EventHandler(this.sakrij_CheckedChanged);
            // 
            // Posalji
            // 
            this.Posalji.Location = new System.Drawing.Point(76, 255);
            this.Posalji.Name = "Posalji";
            this.Posalji.Size = new System.Drawing.Size(142, 49);
            this.Posalji.TabIndex = 4;
            this.Posalji.Text = "Pošalji";
            this.Posalji.UseVisualStyleBackColor = true;
            this.Posalji.Click += new System.EventHandler(this.Posalji_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(294, 49);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(398, 158);
            this.txtbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.Posalji);
            this.Controls.Add(this.sakrij);
            this.Controls.Add(this.vecera);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.dorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucak;
        private System.Windows.Forms.CheckBox rucak;
        private System.Windows.Forms.CheckBox vecera;
        private System.Windows.Forms.CheckBox sakrij;
        private System.Windows.Forms.Button Posalji;
        private System.Windows.Forms.TextBox txtbox;
    }
}

