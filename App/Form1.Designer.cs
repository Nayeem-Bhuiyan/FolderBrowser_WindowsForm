namespace App
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseReference = new System.Windows.Forms.Button();
            this.txtReferenceFolderDirectory = new System.Windows.Forms.TextBox();
            this.btnCreateRef = new System.Windows.Forms.Button();
            this.cmbCodeLength = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse Raw Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(358, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(853, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 277);
            this.listBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // btnBrowseReference
            // 
            this.btnBrowseReference.Location = new System.Drawing.Point(899, 334);
            this.btnBrowseReference.Name = "btnBrowseReference";
            this.btnBrowseReference.Size = new System.Drawing.Size(127, 23);
            this.btnBrowseReference.TabIndex = 10;
            this.btnBrowseReference.Text = "Ref Folder Browse";
            this.btnBrowseReference.UseVisualStyleBackColor = true;
            this.btnBrowseReference.Click += new System.EventHandler(this.btnBrowseReference_Click);
            // 
            // txtReferenceFolderDirectory
            // 
            this.txtReferenceFolderDirectory.Location = new System.Drawing.Point(197, 335);
            this.txtReferenceFolderDirectory.Name = "txtReferenceFolderDirectory";
            this.txtReferenceFolderDirectory.Size = new System.Drawing.Size(696, 20);
            this.txtReferenceFolderDirectory.TabIndex = 11;
            // 
            // btnCreateRef
            // 
            this.btnCreateRef.Location = new System.Drawing.Point(899, 381);
            this.btnCreateRef.Name = "btnCreateRef";
            this.btnCreateRef.Size = new System.Drawing.Size(127, 35);
            this.btnCreateRef.TabIndex = 12;
            this.btnCreateRef.Text = "Create Ref";
            this.btnCreateRef.UseVisualStyleBackColor = true;
            this.btnCreateRef.Click += new System.EventHandler(this.btnCreateRef_Click);
            // 
            // cmbCodeLength
            // 
            this.cmbCodeLength.FormattingEnabled = true;
            this.cmbCodeLength.Location = new System.Drawing.Point(205, 103);
            this.cmbCodeLength.Name = "cmbCodeLength";
            this.cmbCodeLength.Size = new System.Drawing.Size(162, 21);
            this.cmbCodeLength.TabIndex = 13;
            this.cmbCodeLength.SelectedIndexChanged += new System.EventHandler(this.cmbCodeLength_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Code Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCodeLength);
            this.Controls.Add(this.btnCreateRef);
            this.Controls.Add(this.txtReferenceFolderDirectory);
            this.Controls.Add(this.btnBrowseReference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseReference;
        private System.Windows.Forms.TextBox txtReferenceFolderDirectory;
        private System.Windows.Forms.Button btnCreateRef;
        private System.Windows.Forms.ComboBox cmbCodeLength;
        private System.Windows.Forms.Label label4;
    }
}

