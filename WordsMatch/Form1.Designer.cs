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
            this.formatterTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formatterSourceBox = new System.Windows.Forms.TextBox();
            this.formatterOtherBox = new System.Windows.Forms.TextBox();
            this.removeBox = new System.Windows.Forms.TextBox();
            this.afterBox = new System.Windows.Forms.TextBox();
            this.beforeBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.swapBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.matcherPage.SuspendLayout();
            this.formatterTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceBox
            // 
            this.sourceBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sourceBox.Location = new System.Drawing.Point(22, 32);
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
            this.otherBox.Location = new System.Drawing.Point(350, 32);
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
            this.matchBox.Location = new System.Drawing.Point(223, 48);
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
            this.groupBox1.Location = new System.Drawing.Point(131, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
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
            // formatterTab
            // 
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "After";
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
            // formatterSourceBox
            // 
            this.formatterSourceBox.Location = new System.Drawing.Point(27, 26);
            this.formatterSourceBox.Multiline = true;
            this.formatterSourceBox.Name = "formatterSourceBox";
            this.formatterSourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formatterSourceBox.Size = new System.Drawing.Size(479, 52);
            this.formatterSourceBox.TabIndex = 0;
            // 
            // formatterOtherBox
            // 
            this.formatterOtherBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.formatterOtherBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formatterOtherBox.Location = new System.Drawing.Point(28, 203);
            this.formatterOtherBox.Multiline = true;
            this.formatterOtherBox.Name = "formatterOtherBox";
            this.formatterOtherBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formatterOtherBox.Size = new System.Drawing.Size(478, 87);
            this.formatterOtherBox.TabIndex = 7;
            // 
            // removeBox
            // 
            this.removeBox.Location = new System.Drawing.Point(16, 26);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(71, 20);
            this.removeBox.TabIndex = 1;
            this.removeBox.TextChanged += new System.EventHandler(this.removeBox_TextChanged);
            // 
            // afterBox
            // 
            this.afterBox.Location = new System.Drawing.Point(95, 29);
            this.afterBox.Name = "afterBox";
            this.afterBox.Size = new System.Drawing.Size(71, 20);
            this.afterBox.TabIndex = 1;
            // 
            // beforeBox
            // 
            this.beforeBox.Location = new System.Drawing.Point(6, 29);
            this.beforeBox.Name = "beforeBox";
            this.beforeBox.Size = new System.Drawing.Size(71, 20);
            this.beforeBox.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Location = new System.Drawing.Point(431, 174);
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
            this.swapBtn.Location = new System.Drawing.Point(28, 174);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBtn.TabIndex = 3;
            this.swapBtn.Text = "Swap";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.afterBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.beforeBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeBox);
            this.groupBox3.Controls.Add(this.removeBtn);
            this.groupBox3.Location = new System.Drawing.Point(301, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sourceBox);
            this.groupBox4.Controls.Add(this.sourceCount);
            this.groupBox4.Controls.Add(this.matchesCount);
            this.groupBox4.Controls.Add(this.otherCount);
            this.groupBox4.Controls.Add(this.matchBox);
            this.groupBox4.Controls.Add(this.otherBox);
            this.groupBox4.Location = new System.Drawing.Point(-12, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 288);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
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
            this.formatterTab.ResumeLayout(false);
            this.formatterTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}

