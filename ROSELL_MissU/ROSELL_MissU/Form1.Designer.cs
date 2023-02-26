namespace ROSELL_MissU
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
            this.Top_20 = new System.Windows.Forms.ListBox();
            this.Top_10 = new System.Windows.Forms.ListBox();
            this.Top_3 = new System.Windows.Forms.ListBox();
            this.Miss_Universe = new System.Windows.Forms.ListBox();
            this.btn_t20 = new System.Windows.Forms.Button();
            this.btn_t10 = new System.Windows.Forms.Button();
            this.btn_t3 = new System.Windows.Forms.Button();
            this.btn_missU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Top_20
            // 
            this.Top_20.FormattingEnabled = true;
            this.Top_20.Items.AddRange(new object[] {
            "Albania",
            "Angola",
            "Argentina",
            "Armenia",
            "Brazil",
            "Chile",
            "China",
            "Colombia",
            "Ecuador",
            "France",
            "Germany",
            "Greece",
            "Haiti",
            "India",
            "Japan",
            "Mexico",
            "Nepal",
            "Netherlands",
            "Philippines",
            "Poland",
            ""});
            this.Top_20.Location = new System.Drawing.Point(12, 143);
            this.Top_20.Name = "Top_20";
            this.Top_20.Size = new System.Drawing.Size(143, 342);
            this.Top_20.TabIndex = 0;
            this.Top_20.SelectedIndexChanged += new System.EventHandler(this.Top_20_SelectedIndexChanged);
            // 
            // Top_10
            // 
            this.Top_10.FormattingEnabled = true;
            this.Top_10.Location = new System.Drawing.Point(256, 143);
            this.Top_10.Name = "Top_10";
            this.Top_10.Size = new System.Drawing.Size(143, 342);
            this.Top_10.TabIndex = 0;
            this.Top_10.SelectedIndexChanged += new System.EventHandler(this.Top_10_SelectedIndexChanged);
            // 
            // Top_3
            // 
            this.Top_3.FormattingEnabled = true;
            this.Top_3.Location = new System.Drawing.Point(490, 143);
            this.Top_3.Name = "Top_3";
            this.Top_3.Size = new System.Drawing.Size(143, 342);
            this.Top_3.TabIndex = 0;
            this.Top_3.SelectedIndexChanged += new System.EventHandler(this.Top_3_SelectedIndexChanged);
            // 
            // Miss_Universe
            // 
            this.Miss_Universe.FormattingEnabled = true;
            this.Miss_Universe.Location = new System.Drawing.Point(720, 143);
            this.Miss_Universe.Name = "Miss_Universe";
            this.Miss_Universe.Size = new System.Drawing.Size(143, 342);
            this.Miss_Universe.TabIndex = 0;
            // 
            // btn_t20
            // 
            this.btn_t20.Location = new System.Drawing.Point(161, 282);
            this.btn_t20.Name = "btn_t20";
            this.btn_t20.Size = new System.Drawing.Size(75, 23);
            this.btn_t20.TabIndex = 1;
            this.btn_t20.Text = "Save";
            this.btn_t20.UseVisualStyleBackColor = true;
            this.btn_t20.Click += new System.EventHandler(this.btn_t20_Click);
            // 
            // btn_t10
            // 
            this.btn_t10.Location = new System.Drawing.Point(409, 282);
            this.btn_t10.Name = "btn_t10";
            this.btn_t10.Size = new System.Drawing.Size(75, 23);
            this.btn_t10.TabIndex = 2;
            this.btn_t10.Text = "Save";
            this.btn_t10.UseVisualStyleBackColor = true;
            this.btn_t10.Click += new System.EventHandler(this.btn_t10_Click);
            // 
            // btn_t3
            // 
            this.btn_t3.Location = new System.Drawing.Point(639, 282);
            this.btn_t3.Name = "btn_t3";
            this.btn_t3.Size = new System.Drawing.Size(75, 23);
            this.btn_t3.TabIndex = 2;
            this.btn_t3.Text = "Save";
            this.btn_t3.UseVisualStyleBackColor = true;
            this.btn_t3.Click += new System.EventHandler(this.btn_t3_Click);
            // 
            // btn_missU
            // 
            this.btn_missU.Location = new System.Drawing.Point(869, 282);
            this.btn_missU.Name = "btn_missU";
            this.btn_missU.Size = new System.Drawing.Size(69, 23);
            this.btn_missU.TabIndex = 2;
            this.btn_missU.Text = "Save";
            this.btn_missU.UseVisualStyleBackColor = true;
            this.btn_missU.Click += new System.EventHandler(this.btn_missU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Top 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miss Universe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 616);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_missU);
            this.Controls.Add(this.btn_t3);
            this.Controls.Add(this.btn_t10);
            this.Controls.Add(this.btn_t20);
            this.Controls.Add(this.Miss_Universe);
            this.Controls.Add(this.Top_3);
            this.Controls.Add(this.Top_10);
            this.Controls.Add(this.Top_20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Top_20;
        private System.Windows.Forms.ListBox Top_10;
        private System.Windows.Forms.ListBox Top_3;
        private System.Windows.Forms.ListBox Miss_Universe;
        private System.Windows.Forms.Button btn_t20;
        private System.Windows.Forms.Button btn_t10;
        private System.Windows.Forms.Button btn_t3;
        private System.Windows.Forms.Button btn_missU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

