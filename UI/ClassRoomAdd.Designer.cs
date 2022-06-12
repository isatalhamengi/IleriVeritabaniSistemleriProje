namespace UI
{
    partial class ClassRoomAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.txtcrtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "B_ID";
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(56, 45);
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(296, 23);
            this.txtbid.TabIndex = 1;
            // 
            // txtcrtid
            // 
            this.txtcrtid.Location = new System.Drawing.Point(56, 89);
            this.txtcrtid.Name = "txtcrtid";
            this.txtcrtid.Size = new System.Drawing.Size(296, 23);
            this.txtcrtid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRT_ID";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(56, 135);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(296, 23);
            this.txtname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(56, 184);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(296, 23);
            this.txtdesc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desc";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(277, 229);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // ClassRoomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 300);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcrtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbid);
            this.Controls.Add(this.label1);
            this.Name = "ClassRoomAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassRoomAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtbid;
        private TextBox txtcrtid;
        private Label label2;
        private TextBox txtname;
        private Label label3;
        private TextBox txtdesc;
        private Label label4;
        private Button btnekle;
    }
}