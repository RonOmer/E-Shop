namespace EShop
{
    partial class FormAddProductToBuyer
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.SubmitBut = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtID.Location = new System.Drawing.Point(173, 270);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 26);
            this.txtID.TabIndex = 18;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblID.Location = new System.Drawing.Point(49, 272);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(139, 25);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "Choose an ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBuyerName.Location = new System.Drawing.Point(184, 48);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(125, 26);
            this.txtBuyerName.TabIndex = 14;
            this.txtBuyerName.TextChanged += new System.EventHandler(this.txtSellerName_TextChanged);
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBuyerName.Location = new System.Drawing.Point(24, 51);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(154, 25);
            this.lblBuyerName.TabIndex = 13;
            this.lblBuyerName.Text = "Name of buyer:";
            this.lblBuyerName.Click += new System.EventHandler(this.lblSellerName_Click);
            // 
            // SubmitBut
            // 
            this.SubmitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubmitBut.Location = new System.Drawing.Point(396, 263);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(98, 39);
            this.SubmitBut.TabIndex = 19;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.Click += new System.EventHandler(this.SubmitBut_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtdata.Location = new System.Drawing.Point(27, 90);
            this.txtdata.Multiline = true;
            this.txtdata.Name = "txtdata";
            this.txtdata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdata.Size = new System.Drawing.Size(563, 148);
            this.txtdata.TabIndex = 20;
            this.txtdata.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // FormAddProductToBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 326);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.SubmitBut);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.lblBuyerName);
            this.Name = "FormAddProductToBuyer";
            this.Text = "FromAddProductToBuyer";
            this.Load += new System.EventHandler(this.FromAddProductToBuyer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.TextBox txtdata;
    }
}