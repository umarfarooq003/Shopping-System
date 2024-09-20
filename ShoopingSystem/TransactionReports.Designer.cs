namespace ShoopingSystem
{
    partial class TransactionReports
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
            this.TransSubmitBtn = new System.Windows.Forms.Button();
            this.OrderIDtxtbox = new System.Windows.Forms.TextBox();
            this.CustoIDtxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentIDtxtBox = new System.Windows.Forms.TextBox();
            this.ProductIDtxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransSubmitBtn
            // 
            this.TransSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransSubmitBtn.Location = new System.Drawing.Point(703, 192);
            this.TransSubmitBtn.Name = "TransSubmitBtn";
            this.TransSubmitBtn.Size = new System.Drawing.Size(147, 37);
            this.TransSubmitBtn.TabIndex = 23;
            this.TransSubmitBtn.Text = "Submit";
            this.TransSubmitBtn.UseVisualStyleBackColor = true;
            this.TransSubmitBtn.Click += new System.EventHandler(this.TransSubmitBtn_Click);
            // 
            // OrderIDtxtbox
            // 
            this.OrderIDtxtbox.Location = new System.Drawing.Point(598, 87);
            this.OrderIDtxtbox.Multiline = true;
            this.OrderIDtxtbox.Name = "OrderIDtxtbox";
            this.OrderIDtxtbox.Size = new System.Drawing.Size(252, 28);
            this.OrderIDtxtbox.TabIndex = 22;
            // 
            // CustoIDtxtBox
            // 
            this.CustoIDtxtBox.Location = new System.Drawing.Point(171, 87);
            this.CustoIDtxtBox.Multiline = true;
            this.CustoIDtxtBox.Name = "CustoIDtxtBox";
            this.CustoIDtxtBox.Size = new System.Drawing.Size(229, 28);
            this.CustoIDtxtBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Transaction Reports";
            // 
            // PaymentIDtxtBox
            // 
            this.PaymentIDtxtBox.Location = new System.Drawing.Point(598, 139);
            this.PaymentIDtxtBox.Multiline = true;
            this.PaymentIDtxtBox.Name = "PaymentIDtxtBox";
            this.PaymentIDtxtBox.Size = new System.Drawing.Size(252, 28);
            this.PaymentIDtxtBox.TabIndex = 27;
            // 
            // ProductIDtxtBox
            // 
            this.ProductIDtxtBox.Location = new System.Drawing.Point(171, 142);
            this.ProductIDtxtBox.Multiline = true;
            this.ProductIDtxtBox.Name = "ProductIDtxtBox";
            this.ProductIDtxtBox.Size = new System.Drawing.Size(229, 28);
            this.ProductIDtxtBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Payment ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Product  ID";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(568, 389);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(167, 37);
            this.cancelbtn.TabIndex = 30;
            this.cancelbtn.Text = "Close";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.Location = new System.Drawing.Point(180, 389);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(167, 37);
            this.loadbtn.TabIndex = 29;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 137);
            this.dataGridView1.TabIndex = 28;
            // 
            // TransactionReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PaymentIDtxtBox);
            this.Controls.Add(this.ProductIDtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransSubmitBtn);
            this.Controls.Add(this.OrderIDtxtbox);
            this.Controls.Add(this.CustoIDtxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionReports";
            this.Text = "TransactionReports";
            this.Load += new System.EventHandler(this.TransactionReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TransSubmitBtn;
        private System.Windows.Forms.TextBox OrderIDtxtbox;
        private System.Windows.Forms.TextBox CustoIDtxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaymentIDtxtBox;
        private System.Windows.Forms.TextBox ProductIDtxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}