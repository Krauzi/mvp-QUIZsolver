using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZsolver
{
    public partial class Form3 : Form
    {
        public uint totalPoints;

        #region Properties
        public uint TotalPointsLabel
        {
            set
            {
                labelPoints.Text = totalPoints.ToString();
            }
        }
        #endregion

        #region Events

        #endregion

        public Form3(uint totalPoints)
        {
            InitializeComponent();
            this.totalPoints = totalPoints;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TotalPointsLabel = totalPoints;
        }
    }
}
