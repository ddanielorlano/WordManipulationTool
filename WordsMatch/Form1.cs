using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WordsMatch
{
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();

            MatchButton.Enabled = false;
            matchesCount.Enabled = false;
            ClearButton.Enabled = false;
            matchBox.ReadOnly = true;
        }
        private void MatchButton_Click(object sender, EventArgs e)
        {

            string sourceText = sourceBox.Text;
            string otherText = otherBox.Text;
            if (sourceText != null && otherText != null)
            {
                MatchButton.Enabled = true;
            }
            List<string> sourceWords, otherWords;

            var matches = Matcher.Match(sourceText,otherText,out sourceWords, out otherWords);
            matchBox.Text = String.Join(Environment.NewLine, matches);

            sourceCount.Text = sourceWords.Count().ToString();
            otherCount.Text = otherWords.Count().ToString();
            matchesCount.Enabled = true;
            matchesCount.Text = matches.Count().ToString();
            ClearButton.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {//Except
            string sourceText = sourceBox.Text;
            string otherText = otherBox.Text;
            if (!string.IsNullOrWhiteSpace(sourceText) && !string.IsNullOrWhiteSpace(otherText))
            {
                DifferenceButton.Enabled = true;
            }
            List<string> sourceWords, otherWords;

            var intersection = Matcher.Difference(sourceText,otherText, out sourceWords, out otherWords);
            matchBox.Text = String.Join(Environment.NewLine, intersection);

            matchesCount.Enabled = true;
            sourceCount.Text = sourceWords.Count().ToString();
            otherCount.Text = otherWords.Count().ToString();
            matchesCount.Text = intersection.Count().ToString();

            ClearButton.Enabled = true;
        }
        private void SwapButton_Click(object sender, EventArgs e)
        {
            var sourceText = sourceBox.Text;
            var otherText = otherBox.Text;
            sourceBox.Text = otherText;
            otherBox.Text = sourceText;

        }
        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!MatchButton.Enabled && (sourceBox.Text != null && otherBox.Text != null))
            {
                MatchButton.Enabled = true;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Form form = this;
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is Label)
                {
                    Label l = (Label)control;
                    if (!l.Text.Contains("Paste"))
                        l.Text = String.Empty;
                }
            }
        }
        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Formatter Tab
        private void addBtn_Click(object sender, EventArgs e)
        {
            var before = beforeBox.Text;
            var after = afterBox.Text;
            var sourceWords = formatterSourceBox.Text;

            if(string.IsNullOrWhiteSpace(before) && string.IsNullOrWhiteSpace(after) && string.IsNullOrWhiteSpace(sourceWords))
            {
                MessageBox.Show("Enter Value");
            }
            else if (!string.IsNullOrWhiteSpace(sourceWords))
            {
                var result = Formatter.AddToWord(sourceWords, before, after);
                formatterOtherBox.Text = String.Join(Environment.NewLine, result);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var toRemove = removeBox.Text;
            
            var sourceText = formatterSourceBox.Text;
            if (!string.IsNullOrWhiteSpace(toRemove) && !string.IsNullOrWhiteSpace(sourceText))
            {
                var delimeters = toRemove
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Cast<char>().ToArray();
                var result = Formatter.RemoveFromWords(toRemove,delimeters);
                formatterOtherBox.Text = string.Join(Environment.NewLine, result);
            }
        }
    }
}
