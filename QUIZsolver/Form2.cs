using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZsolver
{
    public partial class Form2 : Form
    {
        IView view = new Form1();

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private string filePath;
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        public uint Time
        {
            get
            {
                return (uint)numericUpDownTime.Value;
            }
            set
            {
                numericUpDownTime.Value = (decimal)value;
            }
        }

        public bool NegativePoints
        {
            get
            {
                return checkBoxNegative.Checked;
            }
            set
            {
                checkBoxNegative.Checked = value;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).FullName;
                openFileDialog1.Filter = "XML (*.xml)|*.xml|JSON (*.json)|*.json";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog1.FileName;
                    labelFileName.Text = "Chosen file: " + openFileDialog1.SafeFileName;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (FilePath != "" || Time == 0)
            {
                Form1.FilePath = FilePath;
                Form1.NegativePoints = NegativePoints;
                Form1.Time = Time;
                this.Close();
            }
        }
    }
}
