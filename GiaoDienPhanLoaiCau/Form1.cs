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

namespace GiaoDienPhanLoaiCau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable table = new DataTable();
        private string fileName;


        // nut hien thi
        private void button1_Click(object sender, EventArgs e)
        {
            table.Clear();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                foreach (string filename in dlg.FileNames)
                {
                    string[] lines = File.ReadAllLines(filename);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string values = lines[i];
                        table.Rows.Add(i + 1, values, phanLoai(filename));
                    }
                }
            }
        }



           

        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;//cmd is full path to python.exe
            start.Arguments = args;//args is path to .py file and any cmd line args
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;  
            start.CreateNoWindow = true;
            MessageBox.Show("Đang xử lý ,chờ một lúc");
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                    
                }
            }
           
        }

        private void run_cmddd(string cmd, string args)
        {
           

         
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(cmd);

            // make sure we can read the output from stdout
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            //myProcessStartInfo.CreateNoWindow = true;
            myProcessStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            myProcessStartInfo.Arguments = args;


            Process myProcess = new Process();
         
            myProcess.StartInfo = myProcessStartInfo;


            myProcess.Start();
  
            myProcess.WaitForExit();

            myProcess.Close();

          
        }



        private void buttonTrain_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = "D:/core_nlp-master/data/phanloai/dev/Link.txt";
                File.WriteAllText(filePath, "");
                foreach (string filename in dlg.FileNames)
                {

                    string a = "D:/core_nlp-master/data/phanloai/train/" + Path.GetFileName(filename);
                    File.AppendAllText(filePath, a + "\n");
                    MessageBox.Show(a);
                }
            }
            run_cmd(@"C:\Users\quang\Anaconda3\python.exe", "D:/core_nlp-master/text_classification/phan_loai.py");
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //   OpenFileDialog dlg = new OpenFileDialog();
            //   dlg.Multiselect = true;
            //   if (dlg.ShowDialog() == DialogResult.OK)
            //   {
            //       string filePath = "D:/core_nlp-master/data/phanloai/dev/Link.txt";
            //       File.WriteAllText(filePath, "");
            //       foreach (string filename in dlg.FileNames)
            //       {
            //
            //           string a = "D:/core_nlp-master/data/phanloai/test/" + Path.GetFileName(filename);
            //           File.AppendAllText(filePath, a + "\n");
            //           MessageBox.Show(a);
            //       }
            //   }
            run_cmd("C:/Users/quang/Anaconda3/python.exe", "D:/core_nlp-master/text_classification/DuDoanMotFile.py");
            MessageBox.Show("Đã xong");

            table.Clear();
            // string[] listPath = File.ReadAllLines("D:/core_nlp-master/data/phanloai/test_file/link.txt");

            string[] lines = File.ReadAllLines("D:/core_nlp-master/data/phanloai/test_file/pos.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string values = lines[i];
                table.Rows.Add(i + 1, values, phanLoai("D:/core_nlp-master/data/phanloai/test_file/pos.txt"));
            }

            string[] lines1 = File.ReadAllLines("D:/core_nlp-master/data/phanloai/test_file/neu.txt");
            for (int i = 0; i < lines1.Length; i++)
            {
                string values = lines1[i];
                table.Rows.Add(i + 1, values, phanLoai("D:/core_nlp-master/data/phanloai/test_file/neu.txt"));
            }

            string[] lines2 = File.ReadAllLines("D:/core_nlp-master/data/phanloai/test_file/neg.txt");
            for (int i = 0; i < lines2.Length; i++)
            {
                string values = lines2[i];
                table.Rows.Add(i + 1, values, phanLoai("D:/core_nlp-master/data/phanloai/test_file/neg.txt"));
            }
        }

        private void buttonPhanTich_Click(object sender, EventArgs e)
        {
            string cauPhanTich = textCauPhanTich.Text;
            string fileTest = "D:/core_nlp-master/data/phanloai/dev/Test.txt";
            File.WriteAllText(fileTest,cauPhanTich);

            run_cmd("C:/Users/quang/Anaconda3/python.exe", "D:/core_nlp-master/text_classification/DuDoanMotCau.py");
            MessageBox.Show("Đã xong");
            string[] ketQua = File.ReadAllLines("D:/core_nlp-master/data/phanloai/dev/Result.txt");
           
            labelKetQua.Text = ketQua[0];
            MessageBox.Show(labelKetQua.Text);
            labelKetQua.Text = "Kết quả";
            textCauPhanTich.Text = "";

        }

         private string phanLoai(string fileName) {
                     string thuocloai = "";
            if (fileName == @"D:\core_nlp-master\data\phanloai\train\negative.txt")
            {
                thuocloai = "negative";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\test\negative.txt")
            {
                thuocloai = "negative";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\train\neutral.txt")
            {
                thuocloai = "neutral";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\test\neutral.txt")
            {
                thuocloai = "neutral";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\train\positive.txt")
            {
                thuocloai = "positive";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\test\positive.txt")
            {
                thuocloai = "positive";
            }
            //////
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\pos_pos.txt")
            {
                thuocloai = "positive-positive";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\pos_neu.txt")
            {
                thuocloai = "positive-neutral";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\pos_neg.txt")
            {
                thuocloai = "positive-negative";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neu_neu.txt")
            {
                thuocloai = "neutral-neutral";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neu_pos.txt")
            {
                thuocloai = "neutral-positive";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neu_neg.txt")
            {
                thuocloai = "neutral-negative";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neg_neg.txt")
            {
                thuocloai = "negative-negative";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neg_pos.txt")
            {
                thuocloai = "negative-positive";
            }
            else if (fileName == @"D:\core_nlp-master\data\phanloai\result_test\neg_neu.txt")
            {
                thuocloai = "negative-neutral";
            }
            else if (fileName == "D:/core_nlp-master/data/phanloai/test_file/pos.txt")
            {
                thuocloai = "positive";
            }
            else if (fileName == "D:/core_nlp-master/data/phanloai/test_file/neu.txt")
            {
                thuocloai = "neutral";
            }
            else if (fileName == "D:/core_nlp-master/data/phanloai/test_file/neg.txt")
            {
                thuocloai = "negative";
            }

            return thuocloai;
            } 

      

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Câu nhận xét", typeof(string));
            table.Columns.Add("Thuộc loại", typeof(string));
            

            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
    
}
