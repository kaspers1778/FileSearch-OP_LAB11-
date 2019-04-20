using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace OP_LAB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string StartPath;

        string FileToFind;

        bool isRegisterOn;

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_output.Rows.Clear();
            StartPath = txb_StartDirectory.Text;
            FileToFind = txb_FileToFInd.Text;
            isRegisterOn = cb_Register.Checked;

            List<string> FilesToOutput = new List<string>();
            
            Search.FindFile(StartPath,FileToFind,isRegisterOn,FilesToOutput);

            foreach(var file in FilesToOutput)
            {
                dgv_output.Rows.Add(file);
            }
        }

        static void openInExplorer(string path)
        {
            string cmd = "explorer.exe";
            string arg = "/select, " + path;
            Process.Start(cmd, arg);
        }

        private void dgv_output_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string FilePath = dgv_output.CurrentCell.Value.ToString();
            openInExplorer(FilePath);
            //string DirectoryOfFilePath = FilePath.Substring(0, FilePath.LastIndexOf("\\"));
            //System.Diagnostics.Process.Start(DirectoryOfFilePath);
        }
    }
}
