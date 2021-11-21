
namespace Sİnema
{
    partial class Formgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgiris));
            this.btnfilmler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfilmler
            // 
            this.btnfilmler.BackColor = System.Drawing.Color.Transparent;
            this.btnfilmler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnfilmler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfilmler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilmler.Font = new System.Drawing.Font("Algerian", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilmler.Location = new System.Drawing.Point(269, 37);
            this.btnfilmler.Name = "btnfilmler";
            this.btnfilmler.Size = new System.Drawing.Size(273, 52);
            this.btnfilmler.TabIndex = 0;
            this.btnfilmler.Text = "Filmler";
            this.btnfilmler.UseVisualStyleBackColor = false;
            this.btnfilmler.Click += new System.EventHandler(this.btnfilmler_Click);
            // 
            // Formgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfilmler);
            this.Name = "Formgiris";
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfilmler;
    }
}

