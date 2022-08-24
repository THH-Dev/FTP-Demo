using JohnNguyen.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Demo
{
    public partial class MainForm : Form
    {
        string file_name;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            file_name = MyLib.OpenFileDialog(eTypeFile.File_jpg);
            if (file_name == null)
                return;

            txtPath.Text = file_name;

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            MyLib.UploadImage(file_name);
        }
    }
}
