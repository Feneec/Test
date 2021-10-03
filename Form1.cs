using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Table table = new Table();
        List<string> client = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            table.Function();
            this.Controls.Add(table.dataGridView1);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null)
            {
                foreach (string file in files)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (line.Contains("<"))
                        {
                            line.Substring(0, line.IndexOf("<"));
                        }
                        else
                        {
                            if (line.Contains('"'))
                            {
                                client.Add(line.Substring(line.IndexOf("=") + 1).TrimStart('"').TrimEnd('"'));
                            }
                        }
                    }
                }
            }
            table.DynamicTable(client[0], client[1], client[2], client[3],
                client[4], client[5], client[6], client[7], client[8], client[9],
                client[10], client[11], client[12], client[13], client[14]);
            client.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.ValueToList();
        }
    }
}
