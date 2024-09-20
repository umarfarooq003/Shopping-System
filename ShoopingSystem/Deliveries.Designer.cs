namespace ShoopingSystem
{
    partial class Deliveries
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
            this.DelSubmitBtn = new System.Windows.Forms.Button();
            this.CustoIDtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DelSubmitBtn
            // 
            this.DelSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSubmitBtn.Location = new System.Drawing.Point(540, 125);
            this.DelSubmitBtn.Name = "DelSubmitBtn";
            this.DelSubmitBtn.Size = new System.Drawing.Size(105, 35);
            this.DelSubmitBtn.TabIndex = 23;
            this.DelSubmitBtn.Text = "Submit";
            this.DelSubmitBtn.UseVisualStyleBackColor = true;
            this.DelSubmitBtn.Click += new System.EventHandler(this.DelSubmitBtn_Click);
            // 
            // CustoIDtxtbox
            // 
            this.CustoIDtxtbox.Location = new System.Drawing.Point(215, 125);
            this.CustoIDtxtbox.Multiline = true;
            this.CustoIDtxtbox.Name = "CustoIDtxtbox";
            this.CustoIDtxtbox.Size = new System.Drawing.Size(296, 35);
            this.CustoIDtxtbox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer  ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Deliveries";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 156);
            this.dataGridView1.TabIndex = 25;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(473, 372);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(159, 31);
            this.Cancelbtn.TabIndex = 28;
            this.Cancelbtn.Text = "Close";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(215, 372);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(159, 31);
            this.Loadbtn.TabIndex = 27;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DelSubmitBtn);
            this.Controls.Add(this.CustoIDtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Deliveries";
            this.Text = "Deliveries";
            this.Load += new System.EventHandler(this.Deliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelSubmitBtn;
        private System.Windows.Forms.TextBox CustoIDtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Loadbtn;
    }
}