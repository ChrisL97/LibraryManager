﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static GUI.MyUtil;

namespace GUI
{
    public partial class UserDetailForm : Form
    {

        [DllImport("Core.dll")]
        extern static int add_user(int uid, byte[] id, byte[] u_name, byte[] u_class);

        [DllImport("Core.dll")]
        extern static int edit_user(IntPtr p, byte[] id, byte[] u_name, byte[] u_class);

        private IntPtr current = IntPtr.Zero;
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(IntPtr p)
        {
            Node n = (Node)Marshal.PtrToStructure(p, typeof(Node));
            current = n.pointer;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (edit_name.Text.Length == 0 ||
                edit_class.Text.Length == 0 ||
                edit_id.Text.Length == 0)
            {
                showWarningMsgbox("所有项都是必填项。");
                return;
            }
            if (!wstr_is_id(Encoding.Unicode.GetBytes(edit_id.Text)))
            {
                showWarningMsgbox("学号只能由数字和大写字母(A-Z)组成。");
                return;
            }
            int i;
            if (current == IntPtr.Zero)
            {
                i = add_user(getUID(),
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text));
            }
            else
            {
                i = edit_user(current,
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text));
            }
            if (i != 0)
            {
                showWarningMsgbox("学号已存在。");
                return;
            }
            DialogResult = DialogResult.OK;
            MyUtil.PTmp = current;
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            MyUtil.SetMaxLengthHint(edit_name, 5, false);
            MyUtil.SetMaxLengthHint(edit_class, 9, false);
            MyUtil.SetMaxLengthHint(edit_id, 11, true);
            if (current != IntPtr.Zero)
            {
                User u = (User)Marshal.PtrToStructure(current, typeof(User));
                edit_name.Text = Encoding.Unicode.GetString(u.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(u.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(u.u_id).TrimEnd('\0');
            }
        }
    }
}
