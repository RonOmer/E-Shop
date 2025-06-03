namespace EShop
{
    partial class MainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.RBaddseller = new System.Windows.Forms.RadioButton();
            this.RBaddSrotoSeller = new System.Windows.Forms.RadioButton();
            this.RBaddProToBuyer = new System.Windows.Forms.RadioButton();
            this.RBshow = new System.Windows.Forms.RadioButton();
            this.RBaddBuyer = new System.Windows.Forms.RadioButton();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblchoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(98, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(54, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(54, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RBaddseller
            // 
            this.RBaddseller.AutoSize = true;
            this.RBaddseller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBaddseller.Location = new System.Drawing.Point(57, 142);
            this.RBaddseller.Name = "RBaddseller";
            this.RBaddseller.Size = new System.Drawing.Size(120, 29);
            this.RBaddseller.TabIndex = 5;
            this.RBaddseller.Text = "Add seller";
            this.RBaddseller.UseVisualStyleBackColor = true;
            this.RBaddseller.CheckedChanged += new System.EventHandler(this.RBaddseller_CheckedChanged);
            // 
            // RBaddSrotoSeller
            // 
            this.RBaddSrotoSeller.AutoSize = true;
            this.RBaddSrotoSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBaddSrotoSeller.Location = new System.Drawing.Point(57, 208);
            this.RBaddSrotoSeller.Name = "RBaddSrotoSeller";
            this.RBaddSrotoSeller.Size = new System.Drawing.Size(211, 29);
            this.RBaddSrotoSeller.TabIndex = 6;
            this.RBaddSrotoSeller.Text = "Add product to seller";
            this.RBaddSrotoSeller.UseVisualStyleBackColor = true;
            this.RBaddSrotoSeller.CheckedChanged += new System.EventHandler(this.RBaddSrotoSeller_CheckedChanged);
            // 
            // RBaddProToBuyer
            // 
            this.RBaddProToBuyer.AutoSize = true;
            this.RBaddProToBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBaddProToBuyer.Location = new System.Drawing.Point(57, 244);
            this.RBaddProToBuyer.Name = "RBaddProToBuyer";
            this.RBaddProToBuyer.Size = new System.Drawing.Size(214, 29);
            this.RBaddProToBuyer.TabIndex = 7;
            this.RBaddProToBuyer.Text = "Add product to buyer";
            this.RBaddProToBuyer.UseVisualStyleBackColor = true;
            this.RBaddProToBuyer.CheckedChanged += new System.EventHandler(this.RBaddProToBuyer_CheckedChanged);
            // 
            // RBshow
            // 
            this.RBshow.AutoSize = true;
            this.RBshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBshow.Location = new System.Drawing.Point(58, 279);
            this.RBshow.Name = "RBshow";
            this.RBshow.Size = new System.Drawing.Size(284, 29);
            this.RBshow.TabIndex = 8;
            this.RBshow.Text = "Display all buyers and sellers";
            this.RBshow.UseVisualStyleBackColor = true;
            this.RBshow.CheckedChanged += new System.EventHandler(this.RBshow_CheckedChanged);
            // 
            // RBaddBuyer
            // 
            this.RBaddBuyer.AutoSize = true;
            this.RBaddBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBaddBuyer.Location = new System.Drawing.Point(57, 175);
            this.RBaddBuyer.Name = "RBaddBuyer";
            this.RBaddBuyer.Size = new System.Drawing.Size(123, 29);
            this.RBaddBuyer.TabIndex = 10;
            this.RBaddBuyer.Text = "Add buyer";
            this.RBaddBuyer.UseVisualStyleBackColor = true;
            this.RBaddBuyer.CheckedChanged += new System.EventHandler(this.RBaddBuyer_CheckedChanged);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblwelcome.Location = new System.Drawing.Point(52, 42);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(267, 25);
            this.lblwelcome.TabIndex = 11;
            this.lblwelcome.Text = "Welcome to Ruppin\'s Market!";
            // 
            // lblchoose
            // 
            this.lblchoose.AutoSize = true;
            this.lblchoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblchoose.Location = new System.Drawing.Point(52, 108);
            this.lblchoose.Name = "lblchoose";
            this.lblchoose.Size = new System.Drawing.Size(172, 25);
            this.lblchoose.TabIndex = 12;
            this.lblchoose.Text = "Choose an option:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 373);
            this.Controls.Add(this.lblchoose);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.RBaddBuyer);
            this.Controls.Add(this.RBshow);
            this.Controls.Add(this.RBaddProToBuyer);
            this.Controls.Add(this.RBaddSrotoSeller);
            this.Controls.Add(this.RBaddseller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "חנות דיגיטלית";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBaddseller;
        private System.Windows.Forms.RadioButton RBaddSrotoSeller;
        private System.Windows.Forms.RadioButton RBaddProToBuyer;
        private System.Windows.Forms.RadioButton RBshow;
        private System.Windows.Forms.RadioButton RBaddBuyer;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblchoose;
    }
}