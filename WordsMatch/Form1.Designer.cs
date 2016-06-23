namespace WordsMatch
{
    partial class MatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.otherBox = new System.Windows.Forms.TextBox();
            this.MatchButton = new System.Windows.Forms.Button();
            this.matchBox = new System.Windows.Forms.TextBox();
            this.matchesCount = new System.Windows.Forms.Label();
            this.otherCount = new System.Windows.Forms.Label();
            this.sourceCount = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DifferenceButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.matcherPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.formatterTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeBox = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.afterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.beforeBox = new System.Windows.Forms.TextBox();
            this.formatterSourceBox = new System.Windows.Forms.TextBox();
            this.formatterOtherBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.swapBtn = new System.Windows.Forms.Button();
            this.sourcePastBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.otherPasteBtn = new System.Windows.Forms.Button();
            this.formatterPasteBtn = new System.Windows.Forms.Button();
            this.formatterCopyBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.matcherPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.formatterTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceBox
            // 
            this.sourceBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sourceBox.Location = new System.Drawing.Point(22, 43);
            this.sourceBox.Multiline = true;
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceBox.Size = new System.Drawing.Size(186, 248);
            this.sourceBox.TabIndex = 1;
            this.sourceBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // otherBox
            // 
            this.otherBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.otherBox.Location = new System.Drawing.Point(350, 43);
            this.otherBox.Multiline = true;
            this.otherBox.Name = "otherBox";
            this.otherBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otherBox.Size = new System.Drawing.Size(193, 248);
            this.otherBox.TabIndex = 2;
            this.otherBox.TextChanged += new System.EventHandler(this.OtherTextBox_TextChanged);
            // 
            // MatchButton
            // 
            this.MatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MatchButton.Location = new System.Drawing.Point(6, 19);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(58, 23);
            this.MatchButton.TabIndex = 0;
            this.MatchButton.Text = "Match";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // matchBox
            // 
            this.matchBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matchBox.ForeColor = System.Drawing.SystemColors.Info;
            this.matchBox.Location = new System.Drawing.Point(223, 59);
            this.matchBox.Multiline = true;
            this.matchBox.Name = "matchBox";
            this.matchBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.matchBox.Size = new System.Drawing.Size(114, 232);
            this.matchBox.TabIndex = 3;
            this.matchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matchesCount
            // 
            this.matchesCount.AutoSize = true;
            this.matchesCount.Location = new System.Drawing.Point(262, 32);
            this.matchesCount.Name = "matchesCount";
            this.matchesCount.Size = new System.Drawing.Size(0, 13);
            this.matchesCount.TabIndex = 8;
            // 
            // otherCount
            // 
            this.otherCount.AutoSize = true;
            this.otherCount.Location = new System.Drawing.Point(523, 16);
            this.otherCount.Name = "otherCount";
            this.otherCount.Size = new System.Drawing.Size(0, 13);
            this.otherCount.TabIndex = 12;
            // 
            // sourceCount
            // 
            this.sourceCount.AutoSize = true;
            this.sourceCount.Location = new System.Drawing.Point(22, 16);
            this.sourceCount.Name = "sourceCount";
            this.sourceCount.Size = new System.Drawing.Size(0, 13);
            this.sourceCount.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Location = new System.Drawing.Point(198, 19);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(58, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DifferenceButton
            // 
            this.DifferenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DifferenceButton.Location = new System.Drawing.Point(70, 19);
            this.DifferenceButton.Name = "DifferenceButton";
            this.DifferenceButton.Size = new System.Drawing.Size(58, 23);
            this.DifferenceButton.TabIndex = 1;
            this.DifferenceButton.Text = "Except";
            this.DifferenceButton.UseVisualStyleBackColor = true;
            this.DifferenceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SwapButton
            // 
            this.SwapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwapButton.Location = new System.Drawing.Point(134, 19);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(58, 23);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatchButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.SwapButton);
            this.groupBox1.Controls.Add(this.DifferenceButton);
            this.groupBox1.Location = new System.Drawing.Point(133, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.matcherPage);
            this.tabControl1.Controls.Add(this.formatterTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 372);
            this.tabControl1.TabIndex = 24;
            // 
            // matcherPage
            // 
            this.matcherPage.Controls.Add(this.groupBox4);
            this.matcherPage.Controls.Add(this.groupBox1);
            this.matcherPage.Location = new System.Drawing.Point(4, 22);
            this.matcherPage.Name = "matcherPage";
            this.matcherPage.Padding = new System.Windows.Forms.Padding(3);
            this.matcherPage.Size = new System.Drawing.Size(542, 346);
            this.matcherPage.TabIndex = 0;
            this.matcherPage.Text = "Match Words";
            this.matcherPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.otherPasteBtn);
            this.groupBox4.Controls.Add(this.sourcePastBtn);
            this.groupBox4.Controls.Add(this.sourceBox);
            this.groupBox4.Controls.Add(this.sourceCount);
            this.groupBox4.Controls.Add(this.matchesCount);
            this.groupBox4.Controls.Add(this.otherCount);
            this.groupBox4.Controls.Add(this.matchBox);
            this.groupBox4.Controls.Add(this.otherBox);
            this.groupBox4.Location = new System.Drawing.Point(-12, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 297);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // formatterTab
            // 
            this.formatterTab.Controls.Add(this.formatterCopyBtn);
            this.formatterTab.Controls.Add(this.formatterPasteBtn);
            this.formatterTab.Controls.Add(this.groupBox3);
            this.formatterTab.Controls.Add(this.groupBox2);
            this.formatterTab.Controls.Add(this.formatterSourceBox);
            this.formatterTab.Controls.Add(this.formatterOtherBox);
            this.formatterTab.Controls.Add(this.clearBtn);
            this.formatterTab.Controls.Add(this.swapBtn);
            this.formatterTab.Location = new System.Drawing.Point(4, 22);
            this.formatterTab.Name = "formatterTab";
            this.formatterTab.Padding = new System.Windows.Forms.Padding(3);
            this.formatterTab.Size = new System.Drawing.Size(542, 346);
            this.formatterTab.TabIndex = 1;
            this.formatterTab.Text = "Format Words";
            this.formatterTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeBox);
            this.groupBox3.Controls.Add(this.removeBtn);
            this.groupBox3.Location = new System.Drawing.Point(301, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // removeBox
            // 
            this.removeBox.Location = new System.Drawing.Point(16, 26);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(71, 20);
            this.removeBox.TabIndex = 1;
            this.removeBox.TextChanged += new System.EventHandler(this.removeBox_TextChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Location = new System.Drawing.Point(93, 24);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(71, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.afterBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.beforeBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // afterBox
            // 
            this.afterBox.Location = new System.Drawing.Point(95, 29);
            this.afterBox.Name = "afterBox";
            this.afterBox.Size = new System.Drawing.Size(71, 20);
            this.afterBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "After";
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Location = new System.Drawing.Point(183, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Before";
            // 
            // beforeBox
            // 
            this.beforeBox.Location = new System.Drawing.Point(6, 29);
            this.beforeBox.Name = "beforeBox";
            this.beforeBox.Size = new System.Drawing.Size(71, 20);
            this.beforeBox.TabIndex = 0;
            // 
            // formatterSourceBox
            // 
            this.formatterSourceBox.Location = new System.Drawing.Point(27, 44);
            this.formatterSourceBox.Multiline = true;
            this.formatterSourceBox.Name = "formatterSourceBox";
            this.formatterSourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formatterSourceBox.Size = new System.Drawing.Size(479, 66);
            this.formatterSourceBox.TabIndex = 0;
            // 
            // formatterOtherBox
            // 
            this.formatterOtherBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.formatterOtherBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formatterOtherBox.Location = new System.Drawing.Point(28, 250);
            this.formatterOtherBox.Multiline = true;
            this.formatterOtherBox.Name = "formatterOtherBox";
            this.formatterOtherBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formatterOtherBox.Size = new System.Drawing.Size(478, 87);
            this.formatterOtherBox.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Location = new System.Drawing.Point(432, 222);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // swapBtn
            // 
            this.swapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.swapBtn.Location = new System.Drawing.Point(29, 222);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBtn.TabIndex = 3;
            this.swapBtn.Text = "Swap";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // sourcePastBtn
            // 
            this.sourcePastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sourcePastBtn.Location = new System.Drawing.Point(22, 14);
            this.sourcePastBtn.Name = "sourcePastBtn";
            this.sourcePastBtn.Size = new System.Drawing.Size(49, 23);
            this.sourcePastBtn.TabIndex = 14;
            this.sourcePastBtn.Text = "Paste";
            this.sourcePastBtn.UseVisualStyleBackColor = true;
            this.sourcePastBtn.Click += new System.EventHandler(this.sourcePastBtn_Click);
            // 
            // otherPasteBtn
            // 
            this.otherPasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otherPasteBtn.Location = new System.Drawing.Point(494, 11);
            this.otherPasteBtn.Name = "otherPasteBtn";
            this.otherPasteBtn.Size = new System.Drawing.Size(49, 23);
            this.otherPasteBtn.TabIndex = 15;
            this.otherPasteBtn.Text = "Paste";
            this.otherPasteBtn.UseVisualStyleBackColor = true;
            this.otherPasteBtn.Click += new System.EventHandler(this.otherPasteBtn_Click);
            // 
            // formatterPasteBtn
            // 
            this.formatterPasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatterPasteBtn.Location = new System.Drawing.Point(27, 15);
            this.formatterPasteBtn.Name = "formatterPasteBtn";
            this.formatterPasteBtn.Size = new System.Drawing.Size(75, 23);
            this.formatterPasteBtn.TabIndex = 8;
            this.formatterPasteBtn.Text = "Paste";
            this.formatterPasteBtn.UseVisualStyleBackColor = true;
            this.formatterPasteBtn.Click += new System.EventHandler(this.formatterPasteBtn_Click);
            // 
            // formatterCopyBtn
            // 
            this.formatterCopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.formatterCopyBtn.Location = new System.Drawing.Point(211, 221);
            this.formatterCopyBtn.Name = "formatterCopyBtn";
            this.formatterCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.formatterCopyBtn.TabIndex = 9;
            this.formatterCopyBtn.Text = "Copy";
            this.formatterCopyBtn.UseVisualStyleBackColor = true;
            this.formatterCopyBtn.Click += new System.EventHandler(this.formatterCopyBtn_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "MatchForm";
            this.Text = "Tool";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.matcherPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.formatterTab.ResumeLayout(false);
            this.formatterTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.TextBox otherBox;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.TextBox matchBox;
        private System.Windows.Forms.Label matchesCount;
        private System.Windows.Forms.Label otherCount;
        private System.Windows.Forms.Label sourceCount;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DifferenceButton;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage matcherPage;
        private System.Windows.Forms.TabPage formatterTab;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox formatterSourceBox;
        private System.Windows.Forms.TextBox formatterOtherBox;
        private System.Windows.Forms.TextBox removeBox;
        private System.Windows.Forms.TextBox afterBox;
        private System.Windows.Forms.TextBox beforeBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button swapBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button otherPasteBtn;
        private System.Windows.Forms.Button sourcePastBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button formatterCopyBtn;
        private System.Windows.Forms.Button formatterPasteBtn;
    }
}

