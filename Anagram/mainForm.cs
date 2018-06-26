using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Anagram
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void shuffle_btn_Click(object sender, EventArgs e)
        {
            if (source_rtBox.TextLength == 0)
                MessageBox.Show("Source text is empty", "Error");
            else
                anagram_rtBox.Text = AnBuilder.GetAnagram(source_rtBox.Text);
        }

        private void source_rtBox_TextChanged(object sender, EventArgs e)
        {
            length_lblVal.Text = source_rtBox.TextLength.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            source_rtBox.Text = anagram_rtBox.Text = "";
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            loadFileDialog.ShowDialog();
        }

        private void loadFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            source_rtBox.Text = FileSystem.LoadText(loadFileDialog.FileName);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            FileSystem.SaveText(saveFileDialog.FileName, anagram_rtBox.Text);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program made by student of 525b group\nParkhomenko Andrey", "About");
        }
    }
}
