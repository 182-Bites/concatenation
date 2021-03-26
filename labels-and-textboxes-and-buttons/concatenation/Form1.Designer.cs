
namespace concatenation
{
    partial class Concatenation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtZone1 = new System.Windows.Forms.TextBox();
            this.txtZone2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblZone1 = new System.Windows.Forms.Label();
            this.lblZone2 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZone1
            // 
            this.txtZone1.Location = new System.Drawing.Point(148, 22);
            this.txtZone1.Name = "txtZone1";
            this.txtZone1.Size = new System.Drawing.Size(100, 23);
            this.txtZone1.TabIndex = 0;
            // 
            // txtZone2
            // 
            this.txtZone2.Location = new System.Drawing.Point(148, 65);
            this.txtZone2.Name = "txtZone2";
            this.txtZone2.Size = new System.Drawing.Size(100, 23);
            this.txtZone2.TabIndex = 1;
            this.txtZone2.TextChanged += new System.EventHandler(this.txtZone2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(148, 108);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 2;
            // 
            // lblZone1
            // 
            this.lblZone1.AutoSize = true;
            this.lblZone1.Location = new System.Drawing.Point(12, 22);
            this.lblZone1.Name = "lblZone1";
            this.lblZone1.Size = new System.Drawing.Size(43, 15);
            this.lblZone1.TabIndex = 3;
            this.lblZone1.Text = "Zone 1";
            // 
            // lblZone2
            // 
            this.lblZone2.AutoSize = true;
            this.lblZone2.Location = new System.Drawing.Point(12, 65);
            this.lblZone2.Name = "lblZone2";
            this.lblZone2.Size = new System.Drawing.Size(43, 15);
            this.lblZone2.TabIndex = 4;
            this.lblZone2.Text = "Zone 2";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(12, 108);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(39, 15);
            this.lblResultat.TabIndex = 5;
            this.lblResultat.Text = "Result";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 22);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(148, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 22);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Concatenation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 192);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblZone2);
            this.Controls.Add(this.lblZone1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtZone2);
            this.Controls.Add(this.txtZone1);
            this.Name = "Concatenation";
            this.Text = "Concatenation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZone1;
        private System.Windows.Forms.TextBox txtZone2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblZone1;
        private System.Windows.Forms.Label lblZone2;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOk;
    }
}

