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
            txb_Output.Clear();

            StartPath = txb_StartDirectory.Text;
            FileToFind = txb_FileToFInd.Text;
            isRegisterOn = cb_Register.Checked;

            List<string> FilesToOutput = new List<string>();
            
            Search.FindFile(StartPath,FileToFind,isRegisterOn,FilesToOutput);

            foreach(var files in FilesToOutput)
            {
                txb_Output.Text += files + "\r\n";
            }
        }
    }
}
