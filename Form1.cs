using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BatchRename
{
    public partial class Form1 : Form
    {

        private List<RenameEntry> renameFiles = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetFormats(false).Contains("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData("FileDrop");
            renameFiles = null;

            string [] fileNames = data as string[];
            if (fileNames != null)
                lstRename.Items.AddRange(fileNames.OrderBy((x) => x, StringComparer.OrdinalIgnoreCase).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRename.Items.Clear();
            renameFiles = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formatFilename = txtName.Text;
            if (txtName.Text.IndexOf("{#}", 0) < 0)
            {
                MessageBox.Show("The filename needs to have {#}, the index placeholder.");
                return;
            }

            int startIndex;
            if (!int.TryParse(txtIndex.Text, out startIndex))
            {
                MessageBox.Show("The index has to be a number.");
                return;
            }

            int numDigits = (int) txtDigits.Value;

            if (renameFiles == null)
            {
                renameFiles = new List<RenameEntry>();
                System.Random rndGen = new System.Random(DateTime.Now.DayOfYear);
                string rndDigits = "rename-" + rndGen.Next(int.MaxValue - 1).ToString("x") + "-";
                int counter = 0;
                foreach (string item in lstRename.Items)
                {
                    RenameEntry i = new RenameEntry(item);
                    renameFiles.Add(i);
                    i.TemporaryName = rndDigits + counter.ToString();
                    counter++;
                }
            }

            string formatter = "";
            for (int j = 0; j < numDigits; j++)
            {
                formatter += "0";
            }

            lstAfter.Items.Clear();

            foreach (RenameEntry r in renameFiles)
            {
                string formatNum = startIndex.ToString(formatter);
                r.NewName = formatFilename.Replace("{#}", formatNum);
                startIndex++;

                lstAfter.Items.Add(r.NewName);
            }
        }

        private void lstRename_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (renameFiles == null)
            {
                MessageBox.Show("Preview first.");
                return;
            }

            foreach (RenameEntry file in renameFiles)
            {
                if (!file.CanRenameToTemp())
                {
                    MessageBox.Show("(1) Original file missing or (2) temporary filename is already used");
                    return;
                }
            }


            bool okay = true;
            foreach (RenameEntry file in renameFiles)
            {
                if (!file.RenameOldToTemp())
                {
                    MessageBox.Show("Could not rename old filename to temporary filename");
                    okay = false;
                    break;
                }
            }

            if (!okay)
            {
                foreach (RenameEntry file in renameFiles)
                {
                    file.Undo();
                }
                return;
            }

            foreach (RenameEntry file in renameFiles)
            {
                if (!file.CanRenameToNew())
                {
                    MessageBox.Show("Could not rename temporary filename to new filename. A duplicate filename already exists. Stopping.");
                    okay = false;
                    break;
                }
            }

            if (!okay)
            {
                foreach (RenameEntry file in renameFiles)
                {
                    file.Undo();
                }
                return;
            }

            foreach (RenameEntry file in renameFiles)
            {
                if (!file.RenameTempToNew())
                {
                    MessageBox.Show("Problem renaming to the new filename: " + file.TemporaryName);
                    okay = false;
                }
            }

            lstRename.Items.Clear();
            lstAfter.Items.Clear();
            foreach (RenameEntry file in renameFiles)
            {
                lstRename.Items.Add(Path.Combine(file.Directory, file.CurrentName));
            }
            renameFiles = null;
        }

    }
}
