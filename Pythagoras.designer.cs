namespace circle
{
    partial class Pythagoras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbside = new System.Windows.Forms.ComboBox();
            this.lblfirst = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.lblsec = new System.Windows.Forms.Label();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To My Pythagoras Theorem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find for";
            // 
            // cmbside
            // 
            this.cmbside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbside.FormattingEnabled = true;
            this.cmbside.Items.AddRange(new object[] {
            "Adjacent",
            "Hypotenus",
            "Opposite"});
            this.cmbside.Location = new System.Drawing.Point(207, 125);
            this.cmbside.Name = "cmbside";
            this.cmbside.Size = new System.Drawing.Size(172, 28);
            this.cmbside.TabIndex = 2;
            this.cmbside.SelectedIndexChanged += new System.EventHandler(this.cmbside_SelectedIndexChanged);
            // 
            // lblfirst
            // 
            this.lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.ForeColor = System.Drawing.Color.White;
            this.lblfirst.Location = new System.Drawing.Point(12, 176);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(118, 34);
            this.lblfirst.TabIndex = 3;
            this.lblfirst.Text = "First Side";
            // 
            // txtfirst
            // 
            this.txtfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirst.Location = new System.Drawing.Point(207, 176);
            this.txtfirst.Multiline = true;
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(133, 33);
            this.txtfirst.TabIndex = 4;
            this.txtfirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsec
            // 
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.Color.White;
            this.lblsec.Location = new System.Drawing.Point(12, 248);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(154, 34);
            this.lblsec.TabIndex = 5;
            this.lblsec.Text = "Second Side";
            // 
            // txtsec
            // 
            this.txtsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsec.Location = new System.Drawing.Point(207, 248);
            this.txtsec.Multiline = true;
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(133, 33);
            this.txtsec.TabIndex = 6;
            this.txtsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Answer";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.ForeColor = System.Drawing.Color.White;
            this.lblanswer.Location = new System.Drawing.Point(214, 322);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(17, 18);
            this.lblanswer.TabIndex = 8;
            this.lblanswer.Text = "=";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(207, 366);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Pythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(441, 433);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.lblfirst);
            this.Controls.Add(this.cmbside);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pythagoras";
            this.Text = "Pythagoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbside;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}