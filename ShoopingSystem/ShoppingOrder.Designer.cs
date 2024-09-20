namespace ShoopingSystem
{
    partial class ShoppingOrder
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
            this.ShopingSubmitBtn = new System.Windows.Forms.Button();
            this.prdIDtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopingSubmitBtn
            // 
            this.ShopingSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopingSubmitBtn.Location = new System.Drawing.Point(496, 134);
            this.ShopingSubmitBtn.Name = "ShopingSubmitBtn";
            this.ShopingSubmitBtn.Size = new System.Drawing.Size(120, 28);
            this.ShopingSubmitBtn.TabIndex = 23;
            this.ShopingSubmitBtn.Text = "Submit";
            this.ShopingSubmitBtn.UseVisualStyleBackColor = true;
            this.ShopingSubmitBtn.Click += new System.EventHandler(this.ShopingSubmitBtn_Click);
            // 
            // prdIDtxtbox
            // 
            this.prdIDtxtbox.Location = new System.Drawing.Point(163, 134);
            this.prdIDtxtbox.Multiline = true;
            this.prdIDtxtbox.Name = "prdIDtxtbox";
            this.prdIDtxtbox.Size = new System.Drawing.Size(296, 28);
            this.prdIDtxtbox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Shopping Order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 156);
            this.dataGridView1.TabIndex = 24;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(199, 361);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(159, 31);
            this.Loadbtn.TabIndex = 25;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(457, 361);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(159, 31);
            this.Cancelbtn.TabIndex = 26;
            this.Cancelbtn.Text = "Close";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // ShoppingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShopingSubmitBtn);
            this.Controls.Add(this.prdIDtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ShoppingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingOrder";
            this.Load += new System.EventHandler(this.ShoppingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShopingSubmitBtn;
        private System.Windows.Forms.TextBox prdIDtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}