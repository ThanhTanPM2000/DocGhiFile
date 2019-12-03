using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnopen.Click += btnopen_Click;
            this.btnsave.Click += btnsave_Click;
        }

        void btnsave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var content = this.txtContent.Text;
                File.WriteAllText(dialog.FileName, content);
            }
        }

        void btnopen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog(); 
            if(dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                var content = File.ReadAllText(dialog.FileName);
                this.txtContent.Text = content;
            }
        }
    }
}
