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
            matchBox.ReadOnly = true;
        }
        private void MatchButton_Click(object sender, EventArgs e)
        {

            string sourceText = sourceBox.Text;
            string otherText = otherBox.Text;
            if (!string.IsNullOrWhiteSpace(sourceText) && !string.IsNullOrWhiteSpace(otherText))
            {
                List<string> sourceWords, otherWords;

                var matches = Matcher.Match(sourceText, otherText, out sourceWords, out otherWords);
                matchBox.Text = String.Join(Environment.NewLine, matches);

                sourceCount.Text = sourceWords.Count().ToString();
                otherCount.Text = otherWords.Count().ToString();
                matchesCount.Enabled = true;
                matchesCount.Text = matches.Count().ToString();
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {//Except
            string sourceText = sourceBox.Text;
            string otherText = otherBox.Text;
            if (!string.IsNullOrWhiteSpace(sourceText) && !string.IsNullOrWhiteSpace(otherText))
            {
                List<string> sourceWords, otherWords;

                var result = Matcher
                    .Difference(sourceText, otherText, out sourceWords, out otherWords);
                matchesCount.Text = result.Count().ToString();
                matchBox.Text = String.Join(Environment.NewLine, result);
                sourceCount.Text = sourceWords.Count().ToString();
                otherCount.Text = otherWords.Count().ToString();
            }
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
            sourceBox.Text = string.Empty;
            otherBox.Text = string.Empty;
            matchBox.Text = string.Empty;

            sourceCount.Text = string.Empty;
            otherCount.Text = string.Empty;
            matchesCount.Text = string.Empty;

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
                formatterOtherBox.Text = String.Join(" ", result);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var toRemove = removeBox.Text;
            var sourceText = formatterSourceBox.Text;

            if (!string.IsNullOrWhiteSpace(toRemove) && !string.IsNullOrWhiteSpace(sourceText))
            {

                try
                {
                    var delimeters = toRemove
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(x => Convert.ToChar(x)).ToArray();
                    var result = Formatter.RemoveFromWords(sourceText, delimeters);
                    formatterOtherBox.Text = string.Join(" ", result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void swapBtn_Click(object sender, EventArgs e)
        {
            var source = formatterSourceBox.Text;
            var other = formatterOtherBox.Text;
            formatterSourceBox.Text = other;
            formatterOtherBox.Text = source;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            formatterSourceBox.Text = "";
            formatterOtherBox.Text = "";
        }
        private void removeBox_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
