namespace BatchRename
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
            this.lstRename = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDigits = new System.Windows.Forms.NumericUpDown();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstAfter = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRename
            // 
            this.lstRename.AllowDrop = true;
            this.lstRename.FormattingEnabled = true;
            this.lstRename.HorizontalScrollbar = true;
            this.lstRename.Location = new System.Drawing.Point(12, 23);
            this.lstRename.Name = "lstRename";
            this.lstRename.Size = new System.Drawing.Size(251, 225);
            this.lstRename.TabIndex = 0;
            this.lstRename.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.lstRename.SelectedIndexChanged += new System.EventHandler(this.lstRename_SelectedIndexChanged);
            this.lstRename.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.lstRename.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listBox1_GiveFeedback);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag files into here:";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(192, -2);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(71, 30);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filename:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(280, 282);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "IMG_{#}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Starting Index:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(281, 349);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(103, 20);
            this.txtIndex.TabIndex = 6;
            this.txtIndex.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of Digits:";
            // 
            // txtDigits
            // 
            this.txtDigits.Location = new System.Drawing.Point(413, 349);
            this.txtDigits.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.Size = new System.Drawing.Size(72, 20);
            this.txtDigits.TabIndex = 8;
            this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(308, 399);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(76, 32);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(413, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 32);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstAfter
            // 
            this.lstAfter.FormattingEnabled = true;
            this.lstAfter.Location = new System.Drawing.Point(282, 23);
            this.lstAfter.Name = "lstAfter";
            this.lstAfter.Size = new System.Drawing.Size(213, 225);
            this.lstAfter.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAfter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtDigits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRename);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtDigits;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAfter;
        private System.Windows.Forms.Label label5;
    }
}

