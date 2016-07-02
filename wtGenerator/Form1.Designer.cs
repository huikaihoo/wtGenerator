namespace wtGenerator
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
            this.lvMain = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBuild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDir2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBatchUrl = new System.Windows.Forms.TextBox();
            this.tbBatchId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbnCount = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.cbName2 = new System.Windows.Forms.CheckBox();
            this.cbDir1 = new System.Windows.Forms.CheckBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbDir2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDir1 = new System.Windows.Forms.TextBox();
            this.tbUin = new System.Windows.Forms.TextBox();
            this.tbBuild = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbnFindCount = new System.Windows.Forms.NumericUpDown();
            this.tbnGenCount = new System.Windows.Forms.NumericUpDown();
            this.btnDefUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDefDir1 = new System.Windows.Forms.CheckBox();
            this.cbDefName2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDefDir1 = new System.Windows.Forms.TextBox();
            this.tbDefName2 = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnFindCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnGenCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.CheckBoxes = true;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colBuild,
            this.colUin,
            this.colDir2,
            this.colName1,
            this.colCount});
            this.lvMain.Location = new System.Drawing.Point(12, 172);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(547, 124);
            this.lvMain.TabIndex = 2;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colBuild
            // 
            this.colBuild.Text = "build=";
            // 
            // colUin
            // 
            this.colUin.Text = "uni=";
            // 
            // colDir2
            // 
            this.colDir2.Text = "dir_path=";
            // 
            // colName1
            // 
            this.colName1.Text = "name=";
            // 
            // colCount
            // 
            this.colCount.Text = "Count";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(466, 123);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBatchUrl);
            this.groupBox1.Controls.Add(this.tbBatchId);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Batch Input";
            // 
            // tbBatchUrl
            // 
            this.tbBatchUrl.Location = new System.Drawing.Point(80, 21);
            this.tbBatchUrl.Multiline = true;
            this.tbBatchUrl.Name = "tbBatchUrl";
            this.tbBatchUrl.Size = new System.Drawing.Size(461, 96);
            this.tbBatchUrl.TabIndex = 2;
            this.tbBatchUrl.WordWrap = false;
            // 
            // tbBatchId
            // 
            this.tbBatchId.Location = new System.Drawing.Point(6, 21);
            this.tbBatchId.Multiline = true;
            this.tbBatchId.Name = "tbBatchId";
            this.tbBatchId.Size = new System.Drawing.Size(68, 96);
            this.tbBatchId.TabIndex = 1;
            this.tbBatchId.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbnCount);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbName2);
            this.groupBox2.Controls.Add(this.cbName2);
            this.groupBox2.Controls.Add(this.cbDir1);
            this.groupBox2.Controls.Add(this.tbName1);
            this.groupBox2.Controls.Add(this.tbDir2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbDir1);
            this.groupBox2.Controls.Add(this.tbUin);
            this.groupBox2.Controls.Add(this.tbBuild);
            this.groupBox2.Controls.Add(this.tbId);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Input / Update";
            // 
            // tbnCount
            // 
            this.tbnCount.Location = new System.Drawing.Point(62, 218);
            this.tbnCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tbnCount.Name = "tbnCount";
            this.tbnCount.Size = new System.Drawing.Size(100, 22);
            this.tbnCount.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(62, 189);
            this.tbName2.Name = "tbName2";
            this.tbName2.ReadOnly = true;
            this.tbName2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbName2.Size = new System.Drawing.Size(100, 22);
            this.tbName2.TabIndex = 8;
            // 
            // cbName2
            // 
            this.cbName2.AutoSize = true;
            this.cbName2.Checked = true;
            this.cbName2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName2.Location = new System.Drawing.Point(168, 191);
            this.cbName2.Name = "cbName2";
            this.cbName2.Size = new System.Drawing.Size(59, 16);
            this.cbName2.TabIndex = 9;
            this.cbName2.Text = "Locked";
            this.cbName2.UseVisualStyleBackColor = true;
            // 
            // cbDir1
            // 
            this.cbDir1.AutoSize = true;
            this.cbDir1.Checked = true;
            this.cbDir1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDir1.Location = new System.Drawing.Point(168, 107);
            this.cbDir1.Name = "cbDir1";
            this.cbDir1.Size = new System.Drawing.Size(59, 16);
            this.cbDir1.TabIndex = 5;
            this.cbDir1.Text = "Locked";
            this.cbDir1.UseVisualStyleBackColor = true;
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(62, 161);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(100, 22);
            this.tbName1.TabIndex = 7;
            // 
            // tbDir2
            // 
            this.tbDir2.Location = new System.Drawing.Point(62, 133);
            this.tbDir2.Name = "tbDir2";
            this.tbDir2.Size = new System.Drawing.Size(100, 22);
            this.tbDir2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "name=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "dir_path=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "uin=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "buid=";
            // 
            // tbDir1
            // 
            this.tbDir1.Location = new System.Drawing.Point(62, 105);
            this.tbDir1.Name = "tbDir1";
            this.tbDir1.ReadOnly = true;
            this.tbDir1.Size = new System.Drawing.Size(100, 22);
            this.tbDir1.TabIndex = 4;
            // 
            // tbUin
            // 
            this.tbUin.Location = new System.Drawing.Point(62, 77);
            this.tbUin.Name = "tbUin";
            this.tbUin.Size = new System.Drawing.Size(100, 22);
            this.tbUin.TabIndex = 3;
            // 
            // tbBuild
            // 
            this.tbBuild.Location = new System.Drawing.Point(62, 49);
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.Size = new System.Drawing.Size(100, 22);
            this.tbBuild.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(62, 21);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbnFindCount);
            this.groupBox3.Controls.Add(this.tbnGenCount);
            this.groupBox3.Controls.Add(this.btnDefUpdate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbDefDir1);
            this.groupBox3.Controls.Add(this.cbDefName2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbDefDir1);
            this.groupBox3.Controls.Add(this.tbDefName2);
            this.groupBox3.Location = new System.Drawing.Point(253, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 135);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Default value";
            // 
            // tbnFindCount
            // 
            this.tbnFindCount.Location = new System.Drawing.Point(70, 105);
            this.tbnFindCount.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.tbnFindCount.Name = "tbnFindCount";
            this.tbnFindCount.Size = new System.Drawing.Size(100, 22);
            this.tbnFindCount.TabIndex = 18;
            // 
            // tbnGenCount
            // 
            this.tbnGenCount.Location = new System.Drawing.Point(70, 77);
            this.tbnGenCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tbnGenCount.Name = "tbnGenCount";
            this.tbnGenCount.Size = new System.Drawing.Size(100, 22);
            this.tbnGenCount.TabIndex = 16;
            // 
            // btnDefUpdate
            // 
            this.btnDefUpdate.Location = new System.Drawing.Point(225, 105);
            this.btnDefUpdate.Name = "btnDefUpdate";
            this.btnDefUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDefUpdate.TabIndex = 7;
            this.btnDefUpdate.Text = "Update All";
            this.btnDefUpdate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Find Count";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gen Count";
            // 
            // cbDefDir1
            // 
            this.cbDefDir1.AutoSize = true;
            this.cbDefDir1.Checked = true;
            this.cbDefDir1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefDir1.Location = new System.Drawing.Point(233, 27);
            this.cbDefDir1.Name = "cbDefDir1";
            this.cbDefDir1.Size = new System.Drawing.Size(59, 16);
            this.cbDefDir1.TabIndex = 2;
            this.cbDefDir1.Text = "Locked";
            this.cbDefDir1.UseVisualStyleBackColor = true;
            // 
            // cbDefName2
            // 
            this.cbDefName2.AutoSize = true;
            this.cbDefName2.Checked = true;
            this.cbDefName2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefName2.Location = new System.Drawing.Point(233, 52);
            this.cbDefName2.Name = "cbDefName2";
            this.cbDefName2.Size = new System.Drawing.Size(59, 16);
            this.cbDefName2.TabIndex = 4;
            this.cbDefName2.Text = "Locked";
            this.cbDefName2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "name=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "dir_path=";
            // 
            // tbDefDir1
            // 
            this.tbDefDir1.Location = new System.Drawing.Point(62, 21);
            this.tbDefDir1.Name = "tbDefDir1";
            this.tbDefDir1.ReadOnly = true;
            this.tbDefDir1.Size = new System.Drawing.Size(165, 22);
            this.tbDefDir1.TabIndex = 1;
            // 
            // tbDefName2
            // 
            this.tbDefName2.Location = new System.Drawing.Point(62, 49);
            this.tbDefName2.Name = "tbDefName2";
            this.tbDefName2.ReadOnly = true;
            this.tbDefName2.Size = new System.Drawing.Size(165, 22);
            this.tbDefName2.TabIndex = 3;
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGen.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnGen.Location = new System.Drawing.Point(253, 521);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(150, 60);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Orange;
            this.btnFind.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnFind.Location = new System.Drawing.Point(409, 521);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 60);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 597);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMain);
            this.Name = "Form1";
            this.Text = "WT Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnFindCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnGenCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colBuild;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUin;
        private System.Windows.Forms.TextBox tbBuild;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbDefName2;
        private System.Windows.Forms.TextBox tbBatchUrl;
        private System.Windows.Forms.TextBox tbBatchId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.CheckBox cbName2;
        private System.Windows.Forms.CheckBox cbDir1;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbDir2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDir1;
        private System.Windows.Forms.Button btnDefUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbDefDir1;
        private System.Windows.Forms.CheckBox cbDefName2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDefDir1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.NumericUpDown tbnCount;
        private System.Windows.Forms.NumericUpDown tbnFindCount;
        private System.Windows.Forms.NumericUpDown tbnGenCount;
        private System.Windows.Forms.ColumnHeader colUin;
        private System.Windows.Forms.ColumnHeader colDir2;
        private System.Windows.Forms.ColumnHeader colName1;
        private System.Windows.Forms.ColumnHeader colCount;
    }
}

