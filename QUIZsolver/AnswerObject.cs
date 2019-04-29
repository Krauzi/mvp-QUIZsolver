using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZsolver
{
    public partial class AnswerObject : UserControl
    {
        public AnswerObject()
        {
            InitializeComponent();
        }

        public string AnswerText
        {
            get
            {
                return labelAnswer.Text;
            }
            set
            {
                labelAnswer.Text = value;
            }
        }

        public bool AnswerChecked
        {
            get
            {
                return checkBoxAnswer.Checked;
            }
            set
            {
                checkBoxAnswer.Checked = value;
            }
        }
    }
}
