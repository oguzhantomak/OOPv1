namespace OOP.Struct_
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
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(13, 13);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(150, 43);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(12, 62);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(150, 43);
            this.btnStruct.TabIndex = 0;
            this.btnStruct.Text = "Struct";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.BtnStruct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 123);
            this.Controls.Add(this.btnStruct);
            this.Controls.Add(this.btnClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStruct;
    }
}

