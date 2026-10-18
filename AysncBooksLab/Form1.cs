using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AysncBooksLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Kyle Rosa
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport2.Items.Clear();

            List<Task> tasks = new List<Task>();

            // first file (left side)
            var file1 = openFileDialog1.FileName;
            if (!string.IsNullOrWhiteSpace(file1) && File.Exists(file1))
            {
                tasks.Add(ReadBook(file1, lstReport));
            }

            // second file (right side)
            var file2 = openFileDialog2.FileName;
            if (!string.IsNullOrWhiteSpace(file2) && File.Exists(file2))
            {
                tasks.Add(ReadBook(file2, lstReport2));
            }

            if (tasks.Count > 0)
            {
                await Task.WhenAll(tasks);
            }
        }
        //Kyle Rosa
        private async Task ReadBook(string filename, ListBox listBox)
        {
            var lines = await File.ReadAllLinesAsync(filename);

            //Process the lines and remove spaces and punctuation
            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                    .AsParallel()
                                    .Select(x => x.ToLower().Trim().Replace(",", "").Replace(".", "").Replace("!", "")
                                                                   .Replace("?", "").Replace("'", "").Replace("\"", ""));
            //Flattening the array of lines into a single array of words
            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            //Create a dictionary to hold the word counts
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                                         .OrderByDescending(x => x.Value).Take(10);

            foreach (var word in top10)
            {
                listBox.Items.Add($"{word.Key} - {word.Value}");
            }
        }
        //Kyle Rosa
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //Kyle Rosa
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }
    }
}