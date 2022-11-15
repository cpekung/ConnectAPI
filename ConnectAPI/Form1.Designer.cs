namespace ConnectAPI
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
            this.btn_read = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_post = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_json = new System.Windows.Forms.RichTextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.LinkLabel();
            this.lb_copy = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(705, 59);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(109, 30);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_post
            // 
            this.btn_post.Location = new System.Drawing.Point(45, 557);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(769, 50);
            this.btn_post.TabIndex = 2;
            this.btn_post.Text = "POST API";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_filePath
            // 
            this.tb_filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_filePath.Location = new System.Drawing.Point(45, 62);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(600, 27);
            this.tb_filePath.TabIndex = 3;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(651, 59);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(48, 30);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_json
            // 
            this.tb_json.BackColor = System.Drawing.SystemColors.Info;
            this.tb_json.Location = new System.Drawing.Point(45, 406);
            this.tb_json.Name = "tb_json";
            this.tb_json.Size = new System.Drawing.Size(769, 145);
            this.tb_json.TabIndex = 5;
            this.tb_json.Text = "";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_total.Location = new System.Drawing.Point(41, 90);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(124, 20);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "จำนวน 0 รายการ";
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.Location = new System.Drawing.Point(45, 614);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(39, 16);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.TabStop = true;
            this.btn_clear.Text = "Clear";
            this.btn_clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_clear_LinkClicked);
            // 
            // lb_copy
            // 
            this.lb_copy.AutoSize = true;
            this.lb_copy.Location = new System.Drawing.Point(90, 614);
            this.lb_copy.Name = "lb_copy";
            this.lb_copy.Size = new System.Drawing.Size(71, 16);
            this.lb_copy.TabIndex = 8;
            this.lb_copy.TabStop = true;
            this.lb_copy.Text = "Copy Json";
            this.lb_copy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_copy_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 652);
            this.Controls.Add(this.lb_copy);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.tb_json);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_read);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Connect API";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.RichTextBox tb_json;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.LinkLabel btn_clear;
        private System.Windows.Forms.LinkLabel lb_copy;
    }
}

