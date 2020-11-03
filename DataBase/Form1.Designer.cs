namespace DataBase
{
    partial class Form1
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTransformToHTML = new System.Windows.Forms.Button();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxGanre = new System.Windows.Forms.CheckBox();
            this.checkBoxRunningTime = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxRate = new System.Windows.Forms.CheckBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxGanre = new System.Windows.Forms.ComboBox();
            this.comboBoxRunningTime = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQtoXML = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Azure;
            this.buttonSearch.Location = new System.Drawing.Point(142, 444);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(205, 46);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Azure;
            this.buttonClear.Location = new System.Drawing.Point(142, 299);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(211, 44);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTransformToHTML
            // 
            this.buttonTransformToHTML.BackColor = System.Drawing.Color.Azure;
            this.buttonTransformToHTML.Location = new System.Drawing.Point(618, 456);
            this.buttonTransformToHTML.Name = "buttonTransformToHTML";
            this.buttonTransformToHTML.Size = new System.Drawing.Size(517, 47);
            this.buttonTransformToHTML.TabIndex = 2;
            this.buttonTransformToHTML.Text = "Transform to HTML";
            this.buttonTransformToHTML.UseVisualStyleBackColor = false;
            this.buttonTransformToHTML.Click += new System.EventHandler(this.buttonTransformToHTML_Click);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(37, 39);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(67, 21);
            this.checkBoxName.TabIndex = 3;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(37, 79);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(60, 21);
            this.checkBoxYear.TabIndex = 4;
            this.checkBoxYear.Text = "Year";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // checkBoxGanre
            // 
            this.checkBoxGanre.AutoSize = true;
            this.checkBoxGanre.Location = new System.Drawing.Point(37, 126);
            this.checkBoxGanre.Name = "checkBoxGanre";
            this.checkBoxGanre.Size = new System.Drawing.Size(70, 21);
            this.checkBoxGanre.TabIndex = 5;
            this.checkBoxGanre.Text = "Ganre";
            this.checkBoxGanre.UseVisualStyleBackColor = true;
            this.checkBoxGanre.CheckedChanged += new System.EventHandler(this.checkBoxGanre_CheckedChanged);
            // 
            // checkBoxRunningTime
            // 
            this.checkBoxRunningTime.AutoSize = true;
            this.checkBoxRunningTime.Location = new System.Drawing.Point(37, 170);
            this.checkBoxRunningTime.Name = "checkBoxRunningTime";
            this.checkBoxRunningTime.Size = new System.Drawing.Size(118, 21);
            this.checkBoxRunningTime.TabIndex = 6;
            this.checkBoxRunningTime.Text = "Running Time";
            this.checkBoxRunningTime.UseVisualStyleBackColor = true;
            this.checkBoxRunningTime.CheckedChanged += new System.EventHandler(this.checkBoxRunningTime_CheckedChanged);
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(37, 213);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(79, 21);
            this.checkBoxCountry.TabIndex = 7;
            this.checkBoxCountry.Text = "Country";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            this.checkBoxCountry.CheckedChanged += new System.EventHandler(this.checkBoxCountry_CheckedChanged);
            // 
            // checkBoxRate
            // 
            this.checkBoxRate.AutoSize = true;
            this.checkBoxRate.Location = new System.Drawing.Point(37, 253);
            this.checkBoxRate.Name = "checkBoxRate";
            this.checkBoxRate.Size = new System.Drawing.Size(60, 21);
            this.checkBoxRate.TabIndex = 8;
            this.checkBoxRate.Text = "Rate";
            this.checkBoxRate.UseVisualStyleBackColor = true;
            this.checkBoxRate.CheckedChanged += new System.EventHandler(this.checkBoxRate_CheckedChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(225, 36);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(295, 24);
            this.comboBoxName.TabIndex = 9;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(225, 79);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(295, 24);
            this.comboBoxYear.TabIndex = 10;
            // 
            // comboBoxGanre
            // 
            this.comboBoxGanre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGanre.FormattingEnabled = true;
            this.comboBoxGanre.Location = new System.Drawing.Point(225, 123);
            this.comboBoxGanre.Name = "comboBoxGanre";
            this.comboBoxGanre.Size = new System.Drawing.Size(295, 24);
            this.comboBoxGanre.TabIndex = 11;
            // 
            // comboBoxRunningTime
            // 
            this.comboBoxRunningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRunningTime.FormattingEnabled = true;
            this.comboBoxRunningTime.Location = new System.Drawing.Point(225, 167);
            this.comboBoxRunningTime.Name = "comboBoxRunningTime";
            this.comboBoxRunningTime.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRunningTime.TabIndex = 12;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(225, 210);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(295, 24);
            this.comboBoxCountry.TabIndex = 13;
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(225, 253);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRate.TabIndex = 14;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(37, 380);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDOM.TabIndex = 15;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(225, 380);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSAX.TabIndex = 16;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQtoXML
            // 
            this.radioButtonLINQtoXML.AutoSize = true;
            this.radioButtonLINQtoXML.Location = new System.Drawing.Point(411, 380);
            this.radioButtonLINQtoXML.Name = "radioButtonLINQtoXML";
            this.radioButtonLINQtoXML.Size = new System.Drawing.Size(109, 21);
            this.radioButtonLINQtoXML.TabIndex = 17;
            this.radioButtonLINQtoXML.TabStop = true;
            this.radioButtonLINQtoXML.Text = "LINQ to XML";
            this.radioButtonLINQtoXML.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.Location = new System.Drawing.Point(618, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(517, 458);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(49, 24);
            this.ToolStripMenuItemInfo.Text = "Info";
            this.ToolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuItemInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1135, 502);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioButtonLINQtoXML);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.comboBoxRate);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxRunningTime);
            this.Controls.Add(this.comboBoxGanre);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.checkBoxRate);
            this.Controls.Add(this.checkBoxCountry);
            this.Controls.Add(this.checkBoxRunningTime);
            this.Controls.Add(this.checkBoxGanre);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.buttonTransformToHTML);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DataBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTransformToHTML;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxGanre;
        private System.Windows.Forms.CheckBox checkBoxRunningTime;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxRate;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxGanre;
        private System.Windows.Forms.ComboBox comboBoxRunningTime;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQtoXML;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
    }
}

