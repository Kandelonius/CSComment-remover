using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCommentRemover
{
    public partial class Form1 : Form
    {
        private string outputText;
        private TextBox txtb;
        public Form1(string displayText)
        {
            InitializeComponent();
            OutputText = displayText;
            CreateATextBox();
        }

        public string OutputText
        {
            get { return outputText; }
            set { outputText = value; }
        }

        private void CreateATextBox()  
        {    
            txtb = new TextBox();
            txtb.Height = 50;    
            txtb.Width = 200;
            txtb.ForeColor = Color.White;
            txtb.Text = $"{outputText}";
            txtb.ReadOnly = true;
            
        }
    }
}
