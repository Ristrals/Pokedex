using System.Windows.Forms;

namespace Pokedex
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
            this.button1 = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.TextBox();
            this.pokemonShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "JSON data pour Bulbizarre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(12, 74);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.response.Size = new System.Drawing.Size(581, 336);
            this.response.TabIndex = 2;
            this.response.WordWrap = false;
            // 
            // pokemonShow
            // 
            this.pokemonShow.Location = new System.Drawing.Point(617, 74);
            this.pokemonShow.Name = "pokemonShow";
            this.pokemonShow.Size = new System.Drawing.Size(323, 336);
            this.pokemonShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemonShow.TabIndex = 3;
            this.pokemonShow.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(996, 422);
            this.Controls.Add(this.pokemonShow);
            this.Controls.Add(this.response);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox response;
        private PictureBox pokemonShow;
    }
}

