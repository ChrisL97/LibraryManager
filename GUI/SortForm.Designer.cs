﻿namespace GUI
{
    partial class SortForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rad_pos = new System.Windows.Forms.RadioButton();
            this.rad_neg = new System.Windows.Forms.RadioButton();
            this.txt_des = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Location = new System.Drawing.Point(-2, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(414, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 20);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 25);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(328, 20);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(73, 25);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 42);
            this.panel1.TabIndex = 19;
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(9, 8);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(392, 34);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录排序向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(9, 54);
            this.txt_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(54, 17);
            this.txt_type.TabIndex = 42;
            this.txt_type.Text = "类别：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "顺序：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学号",
            "姓名",
            "班级",
            "图书",
            "天数",
            "罚金"});
            this.comboBox1.Location = new System.Drawing.Point(61, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 25);
            this.comboBox1.TabIndex = 44;
            // 
            // rad_pos
            // 
            this.rad_pos.AutoSize = true;
            this.rad_pos.Checked = true;
            this.rad_pos.Location = new System.Drawing.Point(61, 81);
            this.rad_pos.Name = "rad_pos";
            this.rad_pos.Size = new System.Drawing.Size(50, 21);
            this.rad_pos.TabIndex = 45;
            this.rad_pos.TabStop = true;
            this.rad_pos.Text = "正序";
            this.rad_pos.UseVisualStyleBackColor = true;
            // 
            // rad_neg
            // 
            this.rad_neg.AutoSize = true;
            this.rad_neg.Location = new System.Drawing.Point(117, 81);
            this.rad_neg.Name = "rad_neg";
            this.rad_neg.Size = new System.Drawing.Size(50, 21);
            this.rad_neg.TabIndex = 46;
            this.rad_neg.Text = "倒序";
            this.rad_neg.UseVisualStyleBackColor = true;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(7, 219);
            this.txt_des.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(389, 21);
            this.txt_des.TabIndex = 47;
            this.txt_des.Text = "将在目前显示的表中排序；你可能要重置搜索结果来排序整个表。";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 297);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.rad_neg);
            this.Controls.Add(this.rad_pos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortForm";
            this.Text = "超期记录排序向导";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rad_pos;
        private System.Windows.Forms.RadioButton rad_neg;
        private System.Windows.Forms.Label txt_des;
    }
}