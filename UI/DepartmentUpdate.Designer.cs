namespace UI
{
    partial class DepartmentUpdate
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
            this.Güncelle = new System.Windows.Forms.GroupBox();
            this.chktrue = new System.Windows.Forms.CheckBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Güncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Güncelle
            // 
            this.Güncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Güncelle.Controls.Add(this.chktrue);
            this.Güncelle.Controls.Add(this.btnupdate);
            this.Güncelle.Controls.Add(this.txtdesc);
            this.Güncelle.Controls.Add(this.label4);
            this.Güncelle.Controls.Add(this.txtname);
            this.Güncelle.Controls.Add(this.label3);
            this.Güncelle.Controls.Add(this.S);
            this.Güncelle.Controls.Add(this.label1);
            this.Güncelle.Location = new System.Drawing.Point(590, 12);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(397, 248);
            this.Güncelle.TabIndex = 3;
            this.Güncelle.TabStop = false;
            this.Güncelle.Text = "Güncelle";
            // 
            // chktrue
            // 
            this.chktrue.AutoSize = true;
            this.chktrue.Location = new System.Drawing.Point(197, 170);
            this.chktrue.Name = "chktrue";
            this.chktrue.Size = new System.Drawing.Size(48, 19);
            this.chktrue.TabIndex = 18;
            this.chktrue.Text = "True";
            this.chktrue.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(293, 198);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Guncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(72, 132);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(296, 23);
            this.txtdesc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Desc";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(72, 83);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(296, 23);
            this.txtname.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(72, 34);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(296, 23);
            this.S.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "F_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(572, 563);
            this.dataGridView1.TabIndex = 2;
            // 
            // DepartmentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 589);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentUpdate";
            this.Load += new System.EventHandler(this.DepartmentUpdate_Load);
            this.Güncelle.ResumeLayout(false);
            this.Güncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Güncelle;
        private CheckBox chktrue;
        private Button btnupdate;
        private TextBox txtdesc;
        private Label label4;
        private TextBox txtname;
        private Label label3;
        private TextBox S;
        private Label label1;
        private DataGridView dataGridView1;
    }
}