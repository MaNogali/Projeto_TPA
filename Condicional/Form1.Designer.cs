namespace Condicional
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnex4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnex5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnex6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnex7 = new System.Windows.Forms.ToolStripMenuItem();
            this.btncj = new System.Windows.Forms.ToolStripMenuItem();
            this.btnescolha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlooping = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.btnsair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnex4,
            this.btnex5,
            this.btnex6,
            this.btnex7,
            this.btncj,
            this.btnescolha,
            this.btnlooping});
            this.programaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // btnex4
            // 
            this.btnex4.Name = "btnex4";
            this.btnex4.Size = new System.Drawing.Size(252, 34);
            this.btnex4.Text = "Distância";
            this.btnex4.Click += new System.EventHandler(this.btnex4_Click);
            // 
            // btnex5
            // 
            this.btnex5.Name = "btnex5";
            this.btnex5.Size = new System.Drawing.Size(252, 34);
            this.btnex5.Text = "Desconto";
            this.btnex5.Click += new System.EventHandler(this.btnex5_Click);
            // 
            // btnex6
            // 
            this.btnex6.Name = "btnex6";
            this.btnex6.Size = new System.Drawing.Size(252, 34);
            this.btnex6.Text = "Operações";
            this.btnex6.Click += new System.EventHandler(this.btnex6_Click);
            // 
            // btnex7
            // 
            this.btnex7.Name = "btnex7";
            this.btnex7.Size = new System.Drawing.Size(252, 34);
            this.btnex7.Text = "Quadrado e Cubo";
            this.btnex7.Click += new System.EventHandler(this.btnex7_Click);
            // 
            // btncj
            // 
            this.btncj.Name = "btncj";
            this.btncj.Size = new System.Drawing.Size(252, 34);
            this.btncj.Text = "Chico e João";
            this.btncj.Click += new System.EventHandler(this.btncj_Click);
            // 
            // btnescolha
            // 
            this.btnescolha.Name = "btnescolha";
            this.btnescolha.Size = new System.Drawing.Size(252, 34);
            this.btnescolha.Text = "Escolha Operação";
            this.btnescolha.Click += new System.EventHandler(this.btnescolha_Click);
            // 
            // btnlooping
            // 
            this.btnlooping.Name = "btnlooping";
            this.btnlooping.Size = new System.Drawing.Size(252, 34);
            this.btnlooping.Text = "Looping";
            this.btnlooping.Click += new System.EventHandler(this.btnlooping_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Red;
            this.btnsair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(59, 34);
            this.btnsair.Text = "Sair";
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnex4;
        private System.Windows.Forms.ToolStripMenuItem btnex5;
        private System.Windows.Forms.ToolStripMenuItem btnex6;
        private System.Windows.Forms.ToolStripMenuItem btnsair;
        private System.Windows.Forms.ToolStripMenuItem btnex7;
        private System.Windows.Forms.ToolStripMenuItem btncj;
        private System.Windows.Forms.ToolStripMenuItem btnescolha;
        private System.Windows.Forms.ToolStripMenuItem btnlooping;
    }
}

