namespace Ejercicio2
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
            this.lbRango = new System.Windows.Forms.Label();
            this.lbRango2 = new System.Windows.Forms.Label();
            this.lbRangoxy = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.tbRangox = new System.Windows.Forms.TextBox();
            this.tbRangoy = new System.Windows.Forms.TextBox();
            this.btnRango = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRango
            // 
            this.lbRango.AutoSize = true;
            this.lbRango.Location = new System.Drawing.Point(48, 84);
            this.lbRango.Name = "lbRango";
            this.lbRango.Size = new System.Drawing.Size(0, 13);
            this.lbRango.TabIndex = 0;
            // 
            // lbRango2
            // 
            this.lbRango2.AutoSize = true;
            this.lbRango2.Location = new System.Drawing.Point(48, 140);
            this.lbRango2.Name = "lbRango2";
            this.lbRango2.Size = new System.Drawing.Size(0, 13);
            this.lbRango2.TabIndex = 1;
            // 
            // lbRangoxy
            // 
            this.lbRangoxy.AutoSize = true;
            this.lbRangoxy.Location = new System.Drawing.Point(92, 118);
            this.lbRangoxy.Name = "lbRangoxy";
            this.lbRangoxy.Size = new System.Drawing.Size(0, 13);
            this.lbRangoxy.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(350, 118);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(242, 186);
            this.lb.TabIndex = 3;
            // 
            // tbRangox
            // 
            this.tbRangox.Location = new System.Drawing.Point(86, 111);
            this.tbRangox.Name = "tbRangox";
            this.tbRangox.Size = new System.Drawing.Size(100, 20);
            this.tbRangox.TabIndex = 4;
            // 
            // tbRangoy
            // 
            this.tbRangoy.Location = new System.Drawing.Point(86, 168);
            this.tbRangoy.Name = "tbRangoy";
            this.tbRangoy.Size = new System.Drawing.Size(100, 20);
            this.tbRangoy.TabIndex = 5;
            // 
            // btnRango
            // 
            this.btnRango.Location = new System.Drawing.Point(95, 237);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(110, 67);
            this.btnRango.TabIndex = 6;
            this.btnRango.Text = "Agregar Rango";
            this.btnRango.UseVisualStyleBackColor = true;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.tbRangoy);
            this.Controls.Add(this.tbRangox);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbRangoxy);
            this.Controls.Add(this.lbRango2);
            this.Controls.Add(this.lbRango);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRango;
        private System.Windows.Forms.Label lbRango2;
        private System.Windows.Forms.Label lbRangoxy;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.TextBox tbRangox;
        private System.Windows.Forms.TextBox tbRangoy;
        private System.Windows.Forms.Button btnRango;
    }
}

