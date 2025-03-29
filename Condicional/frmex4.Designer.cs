namespace Condicional
{
    partial class frmex4
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
            this.lbldist = new System.Windows.Forms.Label();
            this.lblpremio = new System.Windows.Forms.Label();
            this.btrncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.txtpremio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldist
            // 
            this.lbldist.AutoSize = true;
            this.lbldist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldist.Location = new System.Drawing.Point(92, 83);
            this.lbldist.Name = "lbldist";
            this.lbldist.Size = new System.Drawing.Size(246, 24);
            this.lbldist.TabIndex = 0;
            this.lbldist.Text = "Digite a distância percorrida:";
            // 
            // lblpremio
            // 
            this.lblpremio.AutoSize = true;
            this.lblpremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpremio.Location = new System.Drawing.Point(92, 131);
            this.lblpremio.Name = "lblpremio";
            this.lblpremio.Size = new System.Drawing.Size(156, 24);
            this.lblpremio.TabIndex = 1;
            this.lblpremio.Text = "Seu prêmio é de:";
            // 
            // btrncalcular
            // 
            this.btrncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrncalcular.Location = new System.Drawing.Point(75, 336);
            this.btrncalcular.Name = "btrncalcular";
            this.btrncalcular.Size = new System.Drawing.Size(103, 38);
            this.btrncalcular.TabIndex = 2;
            this.btrncalcular.Text = "Calcular";
            this.btrncalcular.UseVisualStyleBackColor = true;
            this.btrncalcular.Click += new System.EventHandler(this.btrncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(234, 336);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(103, 38);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(398, 336);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(103, 38);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtdist
            // 
            this.txtdist.Location = new System.Drawing.Point(344, 88);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(100, 20);
            this.txtdist.TabIndex = 5;
            // 
            // txtpremio
            // 
            this.txtpremio.Location = new System.Drawing.Point(254, 136);
            this.txtpremio.Name = "txtpremio";
            this.txtpremio.ReadOnly = true;
            this.txtpremio.Size = new System.Drawing.Size(100, 20);
            this.txtpremio.TabIndex = 6;
            // 
            // frmex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpremio);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btrncalcular);
            this.Controls.Add(this.lblpremio);
            this.Controls.Add(this.lbldist);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmex4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldist;
        private System.Windows.Forms.Label lblpremio;
        private System.Windows.Forms.Button btrncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.TextBox txtpremio;
    }
}