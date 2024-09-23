namespace Baitap2
{
    partial class Form2
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
            this.lblmsnv = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmsnv
            // 
            this.lblmsnv.AutoSize = true;
            this.lblmsnv.Location = new System.Drawing.Point(71, 83);
            this.lblmsnv.Name = "lblmsnv";
            this.lblmsnv.Size = new System.Drawing.Size(46, 16);
            this.lblmsnv.TabIndex = 0;
            this.lblmsnv.Text = "MSNV";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(71, 134);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(96, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Tên Nhân Viên";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(76, 199);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(91, 16);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Lương Cơ Bản";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(245, 83);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(205, 22);
            this.txtMa.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(245, 196);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(114, 247);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Đồng Ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(274, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Bỏ Qua";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 308);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblmsnv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmsnv;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
    }
}