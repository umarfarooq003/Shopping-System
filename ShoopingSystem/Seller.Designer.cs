namespace ShoopingSystem
{
    partial class Seller
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
            this.SellerSubmitBtn = new System.Windows.Forms.Button();
            this.prdIDtxtbox = new System.Windows.Forms.TextBox();
            this.SellerNametxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerSubmitBtn
            // 
            this.SellerSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerSubmitBtn.Location = new System.Drawing.Point(170, 215);
            this.SellerSubmitBtn.Name = "SellerSubmitBtn";
            this.SellerSubmitBtn.Size = new System.Drawing.Size(159, 37);
            this.SellerSubmitBtn.TabIndex = 17;
            this.SellerSubmitBtn.Text = "Submit";
            this.SellerSubmitBtn.UseVisualStyleBackColor = true;
            this.SellerSubmitBtn.Click += new System.EventHandler(this.SellerSubmitBtn_Click);
            // 
            // prdIDtxtbox
            // 
            this.prdIDtxtbox.Location = new System.Drawing.Point(135, 171);
            this.prdIDtxtbox.Multiline = true;
            this.prdIDtxtbox.Name = "prdIDtxtbox";
            this.prdIDtxtbox.Size = new System.Drawing.Size(296, 28);
            this.prdIDtxtbox.TabIndex = 16;
            // 
            // SellerNametxtBox
            // 
            this.SellerNametxtBox.Location = new System.Drawing.Point(135, 114);
            this.SellerNametxtBox.Multiline = true;
            this.SellerNametxtBox.Name = "SellerNametxtBox";
            this.SellerNametxtBox.Size = new System.Drawing.Size(296, 28);
            this.SellerNametxtBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seller";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 105);
            this.dataGridView1.TabIndex = 21;
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.Location = new System.Drawing.Point(437, 225);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(125, 37);
            this.loadbtn.TabIndex = 22;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(663, 225);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(125, 37);
            this.cancelbtn.TabIndex = 23;
            this.cancelbtn.Text = "Close";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SellerSubmitBtn);
            this.Controls.Add(this.prdIDtxtbox);
            this.Controls.Add(this.SellerNametxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Seller";
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellerSubmitBtn;
        private System.Windows.Forms.TextBox prdIDtxtbox;
        private System.Windows.Forms.TextBox SellerNametxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}