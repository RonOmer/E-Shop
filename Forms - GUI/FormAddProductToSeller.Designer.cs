namespace EShop
{
    partial class FormAddProductToSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        System.ComponentModel.IContainer components = null;

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
            this.CheckBoxSpecial = new System.Windows.Forms.CheckBox();
            this.SpecialProductBox = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.RBkids = new System.Windows.Forms.RadioButton();
            this.RBclothes = new System.Windows.Forms.RadioButton();
            this.RBoffice = new System.Windows.Forms.RadioButton();
            this.RBElectricity = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxSpecial
            // 
            this.CheckBoxSpecial.AutoSize = true;
            this.CheckBoxSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CheckBoxSpecial.Location = new System.Drawing.Point(258, 155);
            this.CheckBoxSpecial.Name = "CheckBoxSpecial";
            this.CheckBoxSpecial.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxSpecial.TabIndex = 0;
            this.CheckBoxSpecial.UseVisualStyleBackColor = true;
            this.CheckBoxSpecial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SpecialProductBox
            // 
            this.SpecialProductBox.AutoSize = true;
            this.SpecialProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SpecialProductBox.Location = new System.Drawing.Point(14, 146);
            this.SpecialProductBox.Name = "SpecialProductBox";
            this.SpecialProductBox.Size = new System.Drawing.Size(208, 40);
            this.SpecialProductBox.TabIndex = 1;
            this.SpecialProductBox.Text = "Special packaging \r\n(Including an extra charge)";
            this.SpecialProductBox.Click += new System.EventHandler(this.SpecialProductBox_Click);
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSellerName.Location = new System.Drawing.Point(26, 20);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(123, 20);
            this.lblSellerName.TabIndex = 2;
            this.lblSellerName.Text = "Name of seller:";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSellerName.Location = new System.Drawing.Point(218, 17);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(125, 26);
            this.txtSellerName.TabIndex = 3;
            // 
            // RBkids
            // 
            this.RBkids.AutoSize = true;
            this.RBkids.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBkids.Location = new System.Drawing.Point(235, 216);
            this.RBkids.Name = "RBkids";
            this.RBkids.Size = new System.Drawing.Size(63, 24);
            this.RBkids.TabIndex = 4;
            this.RBkids.TabStop = true;
            this.RBkids.Text = "Kids";
            this.RBkids.UseVisualStyleBackColor = true;
            // 
            // RBclothes
            // 
            this.RBclothes.AutoSize = true;
            this.RBclothes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBclothes.Location = new System.Drawing.Point(237, 254);
            this.RBclothes.Name = "RBclothes";
            this.RBclothes.Size = new System.Drawing.Size(87, 24);
            this.RBclothes.TabIndex = 5;
            this.RBclothes.TabStop = true;
            this.RBclothes.Text = "Clothes";
            this.RBclothes.UseVisualStyleBackColor = true;
            // 
            // RBoffice
            // 
            this.RBoffice.AutoSize = true;
            this.RBoffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBoffice.Location = new System.Drawing.Point(235, 294);
            this.RBoffice.Name = "RBoffice";
            this.RBoffice.Size = new System.Drawing.Size(75, 24);
            this.RBoffice.TabIndex = 6;
            this.RBoffice.TabStop = true;
            this.RBoffice.Text = "Office";
            this.RBoffice.UseVisualStyleBackColor = true;
            this.RBoffice.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RBElectricity
            // 
            this.RBElectricity.AutoSize = true;
            this.RBElectricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RBElectricity.Location = new System.Drawing.Point(235, 329);
            this.RBElectricity.Name = "RBElectricity";
            this.RBElectricity.Size = new System.Drawing.Size(104, 24);
            this.RBElectricity.TabIndex = 7;
            this.RBElectricity.TabStop = true;
            this.RBElectricity.Text = "Electricity";
            this.RBElectricity.UseVisualStyleBackColor = true;
            this.RBElectricity.CheckedChanged += new System.EventHandler(this.Electricity_CheckedChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCategory.Location = new System.Drawing.Point(44, 215);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(43, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtprice.Location = new System.Drawing.Point(218, 97);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(125, 26);
            this.txtprice.TabIndex = 10;
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProduct.Location = new System.Drawing.Point(218, 57);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(125, 26);
            this.txtProduct.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name of Product:";
            // 
            // SubmitBut
            // 
            this.SubmitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubmitBut.Location = new System.Drawing.Point(296, 370);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(98, 39);
            this.SubmitBut.TabIndex = 13;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.Click += new System.EventHandler(this.SubmitBut_Click);
            // 
            // FormAddProductToSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 432);
            this.Controls.Add(this.SubmitBut);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.RBElectricity);
            this.Controls.Add(this.RBoffice);
            this.Controls.Add(this.RBclothes);
            this.Controls.Add(this.RBkids);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.SpecialProductBox);
            this.Controls.Add(this.CheckBoxSpecial);
            this.Name = "FormAddProductToSeller";
            this.Text = "FormAddProductToSeller";
            this.Load += new System.EventHandler(this.FormAddProductToSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxSpecial;
        private System.Windows.Forms.Label SpecialProductBox;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.RadioButton RBkids;
        private System.Windows.Forms.RadioButton RBclothes;
        private System.Windows.Forms.RadioButton RBoffice;
        private System.Windows.Forms.RadioButton RBElectricity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBut;
    }
}