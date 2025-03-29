namespace Condicional
{
    partial class frmsplash
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
            this.components = new System.ComponentModel.Container();
            this.pgbsplash = new System.Windows.Forms.ProgressBar();
            this.tmrsplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbsplash
            // 
            this.pgbsplash.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pgbsplash.ForeColor = System.Drawing.Color.DarkOrchid;
            this.pgbsplash.Location = new System.Drawing.Point(96, 413);
            this.pgbsplash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pgbsplash.Name = "pgbsplash";
            this.pgbsplash.Size = new System.Drawing.Size(748, 32);
            this.pgbsplash.TabIndex = 0;
            // 
            // tmrsplash
            // 
            this.tmrsplash.Enabled = true;
            this.tmrsplash.Tick += new System.EventHandler(this.tmrsplash_Tick);
            // 
            // frmsplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Condicional.Properties.Resources.mh_splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.ControlBox = false;
            this.Controls.Add(this.pgbsplash);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmsplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsplash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbsplash;
        private System.Windows.Forms.Timer tmrsplash;
    }
}