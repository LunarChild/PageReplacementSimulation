namespace PageReplace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dgvFIFO = new DataGridView();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            btnFIFO = new Button();
            btnOPT = new Button();
            btnLRU = new Button();
            btnLFU = new Button();
            btnAll = new Button();
            label3 = new Label();
            label4 = new Label();
            dgvOPT = new DataGridView();
            label5 = new Label();
            dgvLRU = new DataGridView();
            label6 = new Label();
            dgvLFU = new DataGridView();
            FIFOCount = new Label();
            OPTCount = new Label();
            LRUCount = new Label();
            LFUCount = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFIFO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOPT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLRU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLFU).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(635, 9);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 1;
            button1.Text = "模拟生成块序列";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvFIFO
            // 
            dgvFIFO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFIFO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFIFO.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFIFO.ColumnHeadersHeight = 34;
            dgvFIFO.Location = new Point(3, 121);
            dgvFIFO.Name = "dgvFIFO";
            dgvFIFO.RowHeadersWidth = 62;
            dgvFIFO.RowTemplate.Height = 32;
            dgvFIFO.Size = new Size(1578, 216);
            dgvFIFO.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 3;
            label1.Text = "块序列长度";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(181, 11);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(112, 30);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Location = new Point(345, 14);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 5;
            label2.Text = "物理块大小";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.Location = new Point(497, 11);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(112, 30);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnFIFO
            // 
            btnFIFO.Anchor = AnchorStyles.None;
            btnFIFO.Location = new Point(813, 9);
            btnFIFO.Name = "btnFIFO";
            btnFIFO.Size = new Size(112, 34);
            btnFIFO.TabIndex = 7;
            btnFIFO.Text = "模拟FIFO";
            btnFIFO.UseVisualStyleBackColor = true;
            btnFIFO.Click += btnFIFO_Click;
            // 
            // btnOPT
            // 
            btnOPT.Anchor = AnchorStyles.None;
            btnOPT.Location = new Point(971, 9);
            btnOPT.Name = "btnOPT";
            btnOPT.Size = new Size(112, 34);
            btnOPT.TabIndex = 8;
            btnOPT.Text = "模拟OPT";
            btnOPT.UseVisualStyleBackColor = true;
            btnOPT.Click += btnOPT_Click;
            // 
            // btnLRU
            // 
            btnLRU.Anchor = AnchorStyles.None;
            btnLRU.Location = new Point(1129, 9);
            btnLRU.Name = "btnLRU";
            btnLRU.Size = new Size(112, 34);
            btnLRU.TabIndex = 9;
            btnLRU.Text = "模拟LRU";
            btnLRU.UseVisualStyleBackColor = true;
            btnLRU.Click += btnLRU_Click;
            // 
            // btnLFU
            // 
            btnLFU.Anchor = AnchorStyles.None;
            btnLFU.Location = new Point(1287, 9);
            btnLFU.Name = "btnLFU";
            btnLFU.Size = new Size(112, 34);
            btnLFU.TabIndex = 10;
            btnLFU.Text = "模拟LFU";
            btnLFU.UseVisualStyleBackColor = true;
            btnLFU.Click += btnLFU_Click;
            // 
            // btnAll
            // 
            btnAll.Anchor = AnchorStyles.None;
            btnAll.Location = new Point(1441, 9);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(112, 34);
            btnAll.TabIndex = 11;
            btnAll.Text = "模拟全部";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(51, 14);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 12;
            label3.Text = "FIFO:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(50, 14);
            label4.Name = "label4";
            label4.Size = new Size(50, 24);
            label4.TabIndex = 13;
            label4.Text = "OPT:";
            // 
            // dgvOPT
            // 
            dgvOPT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOPT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOPT.Location = new Point(3, 402);
            dgvOPT.Name = "dgvOPT";
            dgvOPT.RowHeadersWidth = 62;
            dgvOPT.RowTemplate.Height = 32;
            dgvOPT.Size = new Size(1578, 216);
            dgvOPT.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(51, 10);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 15;
            label5.Text = "LRU:";
            // 
            // dgvLRU
            // 
            dgvLRU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLRU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLRU.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLRU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLRU.Location = new Point(3, 683);
            dgvLRU.Name = "dgvLRU";
            dgvLRU.RowHeadersWidth = 62;
            dgvLRU.RowTemplate.Height = 32;
            dgvLRU.Size = new Size(1578, 216);
            dgvLRU.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(52, 10);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 17;
            label6.Text = "LFU:";
            // 
            // dgvLFU
            // 
            dgvLFU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLFU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLFU.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLFU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLFU.Location = new Point(3, 964);
            dgvLFU.Name = "dgvLFU";
            dgvLFU.RowHeadersWidth = 62;
            dgvLFU.RowTemplate.Height = 32;
            dgvLFU.Size = new Size(1578, 221);
            dgvLFU.TabIndex = 18;
            // 
            // FIFOCount
            // 
            FIFOCount.Anchor = AnchorStyles.None;
            FIFOCount.AutoSize = true;
            FIFOCount.Location = new Point(225, 14);
            FIFOCount.Name = "FIFOCount";
            FIFOCount.Size = new Size(21, 24);
            FIFOCount.TabIndex = 19;
            FIFOCount.Text = "0";
            // 
            // OPTCount
            // 
            OPTCount.Anchor = AnchorStyles.None;
            OPTCount.AutoSize = true;
            OPTCount.Location = new Point(214, 14);
            OPTCount.Name = "OPTCount";
            OPTCount.Size = new Size(21, 24);
            OPTCount.TabIndex = 20;
            OPTCount.Text = "0";
            // 
            // LRUCount
            // 
            LRUCount.Anchor = AnchorStyles.None;
            LRUCount.AutoSize = true;
            LRUCount.Location = new Point(214, 10);
            LRUCount.Name = "LRUCount";
            LRUCount.Size = new Size(21, 24);
            LRUCount.TabIndex = 21;
            LRUCount.Text = "0";
            // 
            // LFUCount
            // 
            LFUCount.Anchor = AnchorStyles.None;
            LFUCount.AutoSize = true;
            LFUCount.Location = new Point(214, 10);
            LFUCount.Name = "LFUCount";
            LFUCount.Size = new Size(21, 24);
            LFUCount.TabIndex = 22;
            LFUCount.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 7);
            tableLayoutPanel1.Controls.Add(dgvLFU, 0, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvLRU, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFIFO, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvOPT, 0, 4);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.Size = new Size(1584, 1188);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label6, 0, 0);
            tableLayoutPanel7.Controls.Add(LFUCount, 1, 0);
            tableLayoutPanel7.Location = new Point(3, 905);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(300, 44);
            tableLayoutPanel7.TabIndex = 25;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(LRUCount, 1, 0);
            tableLayoutPanel6.Location = new Point(3, 624);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(300, 44);
            tableLayoutPanel6.TabIndex = 25;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(OPTCount, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 343);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(300, 53);
            tableLayoutPanel5.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(FIFOCount, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 62);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(315, 53);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1010084F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.Controls.Add(numericUpDown1, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown2, 3, 0);
            tableLayoutPanel2.Controls.Add(button1, 4, 0);
            tableLayoutPanel2.Controls.Add(btnFIFO, 5, 0);
            tableLayoutPanel2.Controls.Add(btnOPT, 6, 0);
            tableLayoutPanel2.Controls.Add(btnLRU, 7, 0);
            tableLayoutPanel2.Controls.Add(btnLFU, 8, 0);
            tableLayoutPanel2.Controls.Add(btnAll, 9, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1572, 53);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(23, 38);
            label7.Name = "label7";
            label7.Size = new Size(54, 24);
            label7.TabIndex = 12;
            label7.Text = "FIFO:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(139, 38);
            label8.Name = "label8";
            label8.Size = new Size(21, 24);
            label8.TabIndex = 19;
            label8.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 1201);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFIFO).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOPT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLRU).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLFU).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dgvFIFO;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button btnFIFO;
        private Button btnOPT;
        private Button btnLRU;
        private Button btnLFU;
        private Button btnAll;
        private Label label3;
        private Label label4;
        private DataGridView dgvOPT;
        private Label label5;
        private DataGridView dgvLRU;
        private Label label6;
        private DataGridView dgvLFU;
        private Label FIFOCount;
        private Label OPTCount;
        private Label LRUCount;
        private Label LFUCount;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Label label8;
    }
}