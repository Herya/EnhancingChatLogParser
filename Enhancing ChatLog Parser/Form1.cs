using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enhancing_ChatLog_Parser
{
    public partial class ChatLogParser : Form
    {
        double                  total = 0;
        double                  success = 0;
        double                  fail = 0;
        public string           toFindSuccess = "You have succeeded in the manastone socketing of Angry Hyperion";
        public string           toFindFail = "You have failed in the manastone socketing of Angry Hyperion";
        public ChatLogParser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult    result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                total = 0;
                success = 0;
                fail = 0;
                parseFile(file, fileName);
                file.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult    result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                parseFile(file, fileName);
                file.Close();
            }
        }

        private void parseFile(System.IO.StreamReader file, string fileName)
        {
            int         size = 0;
            int         count = 0;
            double      percent = 0;
            string      line;

            progressBar1.Value = 0;
            while ((line = file.ReadLine()) != null)
            {
                size++;
            }
            file.Close();
            file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(toFindSuccess))
                {
                    total++;
                    success++;
                }
                else if (line.Contains(toFindFail))
                {
                    total++;
                    fail++;
                }
                count++;
                if ((size / 100) < 100)
                    progressBar1.Value = 100;
                else
                    if (count % (size / 100) == 0)
                        progressBar1.Value += 1;
            }
            totalLabelResult.Text = total.ToString();
            percent = (success / total) * 100;
            successLabelResult.Text = success.ToString() + " (" + Math.Round(percent, 2) + "%)";
            percent = (fail / total) * 100;
            failLabelResult.Text = fail.ToString() + " (" + Math.Round(percent, 2) + "%)";
            file.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void successLabel_Click(object sender, EventArgs e)
        {

        }

        private void failLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openTextInputerButton_Click(object sender, EventArgs e)
        {
            Form            TextInputerForm = new TextInputer();

            //TextInputerForm.Parent = this;
            TextInputerForm.ShowDialog(this);
        }
    }
}
