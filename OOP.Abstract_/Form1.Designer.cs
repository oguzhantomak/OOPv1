namespace OOP.Abstract_
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
            this.btnKeman = new System.Windows.Forms.Button();
            this.btnGitar = new System.Windows.Forms.Button();
            this.btnBateri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeman
            // 
            this.btnKeman.Location = new System.Drawing.Point(13, 13);
            this.btnKeman.Name = "btnKeman";
            this.btnKeman.Size = new System.Drawing.Size(166, 38);
            this.btnKeman.TabIndex = 0;
            this.btnKeman.Text = "Keman";
            this.btnKeman.UseVisualStyleBackColor = true;
            this.btnKeman.Click += new System.EventHandler(this.BtnKeman_Click);
            // 
            // btnGitar
            // 
            this.btnGitar.Location = new System.Drawing.Point(13, 57);
            this.btnGitar.Name = "btnGitar";
            this.btnGitar.Size = new System.Drawing.Size(166, 38);
            this.btnGitar.TabIndex = 0;
            this.btnGitar.Text = "Gitar";
            this.btnGitar.UseVisualStyleBackColor = true;
            this.btnGitar.Click += new System.EventHandler(this.BtnGitar_Click);
            // 
            // btnBateri
            // 
            this.btnBateri.Location = new System.Drawing.Point(12, 101);
            this.btnBateri.Name = "btnBateri";
            this.btnBateri.Size = new System.Drawing.Size(166, 38);
            this.btnBateri.TabIndex = 0;
            this.btnBateri.Text = "Bateri";
            this.btnBateri.UseVisualStyleBackColor = true;
            this.btnBateri.Click += new System.EventHandler(this.BtnBateri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 162);
            this.Controls.Add(this.btnBateri);
            this.Controls.Add(this.btnGitar);
            this.Controls.Add(this.btnKeman);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeman;
        private System.Windows.Forms.Button btnGitar;
        private System.Windows.Forms.Button btnBateri;
    }
}

