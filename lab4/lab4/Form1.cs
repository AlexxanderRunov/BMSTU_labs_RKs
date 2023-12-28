using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private List<string> wordList = new List<string>();
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                string content = File.ReadAllText(openFileDialog1.FileName);
                wordList = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();
                stopwatch.Stop();
                lblLoadTime.Text = $"Load Time: {stopwatch.ElapsedMilliseconds} ms";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchWord))
            {
                listBoxResults.Items.Clear();

                Stopwatch stopwatch = Stopwatch.StartNew();
                IEnumerable<string> results = wordList.Where(word => word.Contains(searchWord));
                foreach (string result in results)
                {
                    listBoxResults.Items.Add(result);
                }
                listBoxResults.EndUpdate();
                stopwatch.Stop();
                lblSearchTime.Text = $"Search Time: {stopwatch.ElapsedMilliseconds} ms";
            }
        }


    }
}