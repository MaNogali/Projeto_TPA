namespace Condicional
{
    partial class frmex7
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
            this.lblint = new System.Windows.Forms.Label();
            this.lblquad = new System.Windows.Forms.Label();
            this.lblcubo = new System.Windows.Forms.Label();
            this.txtquad = new System.Windows.Forms.TextBox();
            this.txtcubo = new System.Windows.Forms.TextBox();
            this.txtint = new System.Windows.Forms.TextBox();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndw = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblint
            // 
            this.lblint.AutoSize = true;
            this.lblint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint.Location = new System.Drawing.Point(48, 86);
            this.lblint.Name = "lblint";
            this.lblint.Size = new System.Drawing.Size(221, 24);
            this.lblint.TabIndex = 0;
            this.lblint.Text = "Digite um número inteiro:";
            // 
            // lblquad
            // 
            this.lblquad.AutoSize = true;
            this.lblquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquad.Location = new System.Drawing.Point(48, 139);
            this.lblquad.Name = "lblquad";
            this.lblquad.Size = new System.Drawing.Size(100, 24);
            this.lblquad.TabIndex = 1;
            this.lblquad.Text = "Quadrado:";
            // 
            // lblcubo
            // 
            this.lblcubo.AutoSize = true;
            this.lblcubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcubo.Location = new System.Drawing.Point(304, 139);
            this.lblcubo.Name = "lblcubo";
            this.lblcubo.Size = new System.Drawing.Size(61, 24);
            this.lblcubo.TabIndex = 2;
            this.lblcubo.Text = "Cubo:";
            // 
            // txtquad
            // 
            this.txtquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquad.Location = new System.Drawing.Point(150, 136);
            this.txtquad.Multiline = true;
            this.txtquad.Name = "txtquad";
            this.txtquad.ReadOnly = true;
            this.txtquad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtquad.Size = new System.Drawing.Size(83, 31);
            this.txtquad.TabIndex = 5;
            // 
            // txtcubo
            // 
            this.txtcubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcubo.Location = new System.Drawing.Point(371, 139);
            this.txtcubo.Multiline = true;
            this.txtcubo.Name = "txtcubo";
            this.txtcubo.ReadOnly = true;
            this.txtcubo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcubo.Size = new System.Drawing.Size(83, 30);
            this.txtcubo.TabIndex = 6;
            // 
            // txtint
            // 
            this.txtint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtint.Location = new System.Drawing.Point(275, 86);
            this.txtint.Name = "txtint";
            this.txtint.Size = new System.Drawing.Size(118, 29);
            this.txtint.TabIndex = 4;
            // 
            // btnwhile
            // 
            this.btnwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhile.Location = new System.Drawing.Point(54, 320);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(110, 33);
            this.btnwhile.TabIndex = 7;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndw
            // 
            this.btndw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndw.Location = new System.Drawing.Point(202, 320);
            this.btndw.Name = "btndw";
            this.btndw.Size = new System.Drawing.Size(110, 32);
            this.btndw.TabIndex = 8;
            this.btndw.Text = "Do While";
            this.btndw.UseVisualStyleBackColor = true;
            this.btndw.Click += new System.EventHandler(this.btndw_Click);
            // 
            // btnfor
            // 
            this.btnfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfor.Location = new System.Drawing.Point(359, 322);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(109, 30);
            this.btnfor.TabIndex = 9;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(123, 376);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(110, 30);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(282, 374);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(109, 32);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndw);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.txtint);
            this.Controls.Add(this.txtcubo);
            this.Controls.Add(this.txtquad);
            this.Controls.Add(this.lblcubo);
            this.Controls.Add(this.lblquad);
            this.Controls.Add(this.lblint);
            this.Name = "frmex7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblint;
        private System.Windows.Forms.Label lblquad;
        private System.Windows.Forms.Label lblcubo;
        private System.Windows.Forms.TextBox txtquad;
        private System.Windows.Forms.TextBox txtcubo;
        private System.Windows.Forms.TextBox txtint;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndw;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}