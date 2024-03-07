namespace SD19306_Bai1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_MSV = new TextBox();
            txt_hoten = new TextBox();
            rtxt_dchi = new RichTextBox();
            label4 = new Label();
            rbtn_nam = new RadioButton();
            rbtn_nu = new RadioButton();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rbtn_kbeauty = new RadioButton();
            rbtn_ptpm = new RadioButton();
            label6 = new Label();
            cbx_Java = new CheckBox();
            cbx_CSharp = new CheckBox();
            cbx_SQL = new CheckBox();
            dtgView = new DataGridView();
            btn_Show = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 37);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // txt_MSV
            // 
            txt_MSV.Location = new Point(205, 48);
            txt_MSV.Name = "txt_MSV";
            txt_MSV.Size = new Size(535, 23);
            txt_MSV.TabIndex = 3;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(205, 105);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(535, 23);
            txt_hoten.TabIndex = 4;
            // 
            // rtxt_dchi
            // 
            rtxt_dchi.Location = new Point(205, 156);
            rtxt_dchi.Name = "rtxt_dchi";
            rtxt_dchi.Size = new Size(535, 96);
            rtxt_dchi.TabIndex = 5;
            rtxt_dchi.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 278);
            label4.Name = "label4";
            label4.Size = new Size(119, 37);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nam.Location = new Point(205, 278);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(92, 41);
            rbtn_nam.TabIndex = 7;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nu.Location = new Point(349, 278);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(71, 41);
            rbtn_nu.TabIndex = 8;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nữ";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 350);
            label5.Name = "label5";
            label5.Size = new Size(97, 37);
            label5.TabIndex = 9;
            label5.Text = "Ngành";
            label5.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn_kbeauty);
            groupBox1.Controls.Add(rbtn_ptpm);
            groupBox1.Location = new Point(187, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 68);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // rbtn_kbeauty
            // 
            rbtn_kbeauty.AutoSize = true;
            rbtn_kbeauty.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_kbeauty.Location = new Point(162, 21);
            rbtn_kbeauty.Name = "rbtn_kbeauty";
            rbtn_kbeauty.Size = new Size(131, 41);
            rbtn_kbeauty.TabIndex = 11;
            rbtn_kbeauty.TabStop = true;
            rbtn_kbeauty.Text = "KBeauty";
            rbtn_kbeauty.UseVisualStyleBackColor = true;
            // 
            // rbtn_ptpm
            // 
            rbtn_ptpm.AutoSize = true;
            rbtn_ptpm.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_ptpm.Location = new Point(18, 21);
            rbtn_ptpm.Name = "rbtn_ptpm";
            rbtn_ptpm.Size = new Size(103, 41);
            rbtn_ptpm.TabIndex = 11;
            rbtn_ptpm.TabStop = true;
            rbtn_ptpm.Text = "PTPM";
            rbtn_ptpm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 419);
            label6.Name = "label6";
            label6.Size = new Size(122, 37);
            label6.TabIndex = 11;
            label6.Text = "Môn học";
            // 
            // cbx_Java
            // 
            cbx_Java.AutoSize = true;
            cbx_Java.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Java.Location = new Point(205, 419);
            cbx_Java.Name = "cbx_Java";
            cbx_Java.Size = new Size(87, 41);
            cbx_Java.TabIndex = 12;
            cbx_Java.Text = "Java";
            cbx_Java.UseVisualStyleBackColor = true;
            // 
            // cbx_CSharp
            // 
            cbx_CSharp.AutoSize = true;
            cbx_CSharp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_CSharp.Location = new Point(349, 419);
            cbx_CSharp.Name = "cbx_CSharp";
            cbx_CSharp.Size = new Size(69, 41);
            cbx_CSharp.TabIndex = 13;
            cbx_CSharp.Text = "C#";
            cbx_CSharp.UseVisualStyleBackColor = true;
            // 
            // cbx_SQL
            // 
            cbx_SQL.AutoSize = true;
            cbx_SQL.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_SQL.Location = new Point(479, 419);
            cbx_SQL.Name = "cbx_SQL";
            cbx_SQL.Size = new Size(83, 41);
            cbx_SQL.TabIndex = 14;
            cbx_SQL.Text = "SQL";
            cbx_SQL.UseVisualStyleBackColor = true;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(26, 493);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(922, 150);
            dtgView.TabIndex = 15;
            // 
            // btn_Show
            // 
            btn_Show.BackColor = Color.Red;
            btn_Show.BackgroundImage = Properties.Resources.capybara_png_4_Transparent_Images_Free;
            btn_Show.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Show.Location = new Point(783, 48);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(165, 439);
            btn_Show.TabIndex = 16;
            btn_Show.Text = "Hiển Thị";
            btn_Show.UseVisualStyleBackColor = false;
            btn_Show.Click += btn_Show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cr;
            ClientSize = new Size(960, 655);
            Controls.Add(btn_Show);
            Controls.Add(dtgView);
            Controls.Add(cbx_SQL);
            Controls.Add(cbx_CSharp);
            Controls.Add(cbx_Java);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(rbtn_nu);
            Controls.Add(rbtn_nam);
            Controls.Add(label4);
            Controls.Add(rtxt_dchi);
            Controls.Add(txt_hoten);
            Controls.Add(txt_MSV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_MSV;
        private TextBox txt_hoten;
        private RichTextBox rtxt_dchi;
        private Label label4;
        private RadioButton rbtn_nam;
        private RadioButton rbtn_nu;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbtn_kbeauty;
        private RadioButton rbtn_ptpm;
        private Label label6;
        private CheckBox cbx_Java;
        private CheckBox cbx_CSharp;
        private CheckBox cbx_SQL;
        private DataGridView dtgView;
        private Button btn_Show;
    }
}