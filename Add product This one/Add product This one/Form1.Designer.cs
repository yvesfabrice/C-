namespace Add_product_This_one
{
    partial class lblAddProduct
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
            this.components = new System.ComponentModel.Container();
            this.lblAddProduct1 = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.DisplayFile = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddProduct1
            // 
            this.lblAddProduct1.AutoSize = true;
            this.lblAddProduct1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct1.Location = new System.Drawing.Point(12, 20);
            this.lblAddProduct1.Name = "lblAddProduct1";
            this.lblAddProduct1.Size = new System.Drawing.Size(85, 17);
            this.lblAddProduct1.TabIndex = 0;
            this.lblAddProduct1.Text = "Add Product";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(23, 71);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(36, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(146, 61);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(130, 20);
            this.txtProductCode.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 117);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(146, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(146, 215);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(130, 23);
            this.btnAddNewProduct.TabIndex = 3;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.Location = new System.Drawing.Point(364, 26);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(334, 212);
            this.lstProduct.TabIndex = 4;
            // 
            // DisplayFile
            // 
            this.DisplayFile.Location = new System.Drawing.Point(469, 251);
            this.DisplayFile.Name = "DisplayFile";
            this.DisplayFile.Size = new System.Drawing.Size(93, 30);
            this.DisplayFile.TabIndex = 5;
            this.DisplayFile.Text = "Display File";
            this.DisplayFile.UseVisualStyleBackColor = true;
            this.DisplayFile.Click += new System.EventHandler(this.DisplayFile_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(48, 220);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 13);
            this.lbltimer.TabIndex = 6;
            // 
            // lblAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 311);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.DisplayFile);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblAddProduct1);
            this.Name = "lblAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.lblAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProduct1;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Button DisplayFile;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbltimer;
    }
}

