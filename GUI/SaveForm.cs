﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class SaveForm : Form
    {

        [DllImport("Core.dll")]
        extern static int write_list();

        public SaveForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rad_backup_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_backup.Checked)
            {
                chk_book.Enabled = true;
                chk_penalty.Enabled = true;
                chk_user.Enabled = true;
            }
            else
            {
                chk_book.Enabled = false;
                chk_penalty.Enabled = false;
                chk_user.Enabled = false;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(rad_save.Checked)
            {
                write_list();
            }
            Dispose();
        }
    }
}
