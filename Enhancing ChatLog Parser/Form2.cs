using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enhancing_ChatLog_Parser
{
    public partial class TextInputer : Form
    {
        public TextInputer()
        {
            InitializeComponent();
            /*  To Change
                inputSuccessTextBox.Text = ((ChatLogParser)this.Owner).toFindSuccess;
                inputFailTextBox.Text = ((ChatLogParser)this.Owner).toFindFail;
             */
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ((ChatLogParser)this.Owner).toFindSuccess = inputSuccessTextBox.Text;
            ((ChatLogParser)this.Owner).toFindFail = inputFailTextBox.Text;
            this.Close();
        }

        private void descriptionFailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
