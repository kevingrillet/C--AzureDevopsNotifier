using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp_AzureDevopsNotifier
{
    [ExcludeFromCodeCoverage]
    partial class EditForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPageAzureDevOpsSettings = new TabPage();
            tableLayoutPanelAzureDevOpsSettings = new TableLayoutPanel();
            labelOrganizationUrl = new Label();
            labelDelay = new Label();
            labelProjectName = new Label();
            labelPersonalAccessToken = new Label();
            textBoxOrganizationUrl = new TextBox();
            textBoxProjectName = new TextBox();
            textBoxPersonalAccessToken = new TextBox();
            numericUpDownDelay = new NumericUpDown();
            tabPageQueries = new TabPage();
            tableLayoutPanelQueries = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageAzureDevOpsSettings.SuspendLayout();
            tableLayoutPanelAzureDevOpsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).BeginInit();
            tabPageQueries.SuspendLayout();
            tableLayoutPanelQueries.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAzureDevOpsSettings);
            tabControl1.Controls.Add(tabPageQueries);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 657);
            tabControl1.TabIndex = 1;
            // 
            // tabPageAzureDevOpsSettings
            // 
            tabPageAzureDevOpsSettings.Controls.Add(tableLayoutPanelAzureDevOpsSettings);
            tabPageAzureDevOpsSettings.Location = new Point(4, 24);
            tabPageAzureDevOpsSettings.Name = "tabPageAzureDevOpsSettings";
            tabPageAzureDevOpsSettings.Padding = new Padding(3);
            tabPageAzureDevOpsSettings.Size = new Size(1256, 629);
            tabPageAzureDevOpsSettings.TabIndex = 0;
            tabPageAzureDevOpsSettings.Text = "AzureDevOpsSettings";
            tabPageAzureDevOpsSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAzureDevOpsSettings
            // 
            tableLayoutPanelAzureDevOpsSettings.ColumnCount = 4;
            tableLayoutPanelAzureDevOpsSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelAzureDevOpsSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelAzureDevOpsSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelAzureDevOpsSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(labelOrganizationUrl, 1, 1);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(labelDelay, 1, 4);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(labelProjectName, 1, 3);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(labelPersonalAccessToken, 1, 2);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(textBoxOrganizationUrl, 2, 1);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(textBoxProjectName, 2, 3);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(textBoxPersonalAccessToken, 2, 2);
            tableLayoutPanelAzureDevOpsSettings.Controls.Add(numericUpDownDelay, 2, 4);
            tableLayoutPanelAzureDevOpsSettings.Dock = DockStyle.Fill;
            tableLayoutPanelAzureDevOpsSettings.Location = new Point(3, 3);
            tableLayoutPanelAzureDevOpsSettings.Name = "tableLayoutPanelAzureDevOpsSettings";
            tableLayoutPanelAzureDevOpsSettings.RowCount = 6;
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelAzureDevOpsSettings.RowStyles.Add(new RowStyle());
            tableLayoutPanelAzureDevOpsSettings.Size = new Size(1250, 623);
            tableLayoutPanelAzureDevOpsSettings.TabIndex = 0;
            // 
            // labelOrganizationUrl
            // 
            labelOrganizationUrl.AutoSize = true;
            labelOrganizationUrl.Dock = DockStyle.Right;
            labelOrganizationUrl.Location = new Point(407, 20);
            labelOrganizationUrl.Name = "labelOrganizationUrl";
            labelOrganizationUrl.Size = new Size(90, 50);
            labelOrganizationUrl.TabIndex = 0;
            labelOrganizationUrl.Text = "OrganizationUrl";
            // 
            // labelDelay
            // 
            labelDelay.AutoSize = true;
            labelDelay.Dock = DockStyle.Right;
            labelDelay.Location = new Point(461, 170);
            labelDelay.Name = "labelDelay";
            labelDelay.Size = new Size(36, 50);
            labelDelay.TabIndex = 3;
            labelDelay.Text = "Delay";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Dock = DockStyle.Right;
            labelProjectName.Location = new Point(421, 120);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(76, 50);
            labelProjectName.TabIndex = 2;
            labelProjectName.Text = "ProjectName";
            // 
            // labelPersonalAccessToken
            // 
            labelPersonalAccessToken.AutoSize = true;
            labelPersonalAccessToken.Dock = DockStyle.Right;
            labelPersonalAccessToken.Location = new Point(378, 70);
            labelPersonalAccessToken.Name = "labelPersonalAccessToken";
            labelPersonalAccessToken.Size = new Size(119, 50);
            labelPersonalAccessToken.TabIndex = 1;
            labelPersonalAccessToken.Text = "PersonalAccessToken";
            // 
            // textBoxOrganizationUrl
            // 
            textBoxOrganizationUrl.Dock = DockStyle.Top;
            textBoxOrganizationUrl.Location = new Point(503, 23);
            textBoxOrganizationUrl.Name = "textBoxOrganizationUrl";
            textBoxOrganizationUrl.Size = new Size(494, 23);
            textBoxOrganizationUrl.TabIndex = 4;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Dock = DockStyle.Top;
            textBoxProjectName.Location = new Point(503, 123);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(494, 23);
            textBoxProjectName.TabIndex = 6;
            // 
            // textBoxPersonalAccessToken
            // 
            textBoxPersonalAccessToken.Dock = DockStyle.Top;
            textBoxPersonalAccessToken.Location = new Point(503, 73);
            textBoxPersonalAccessToken.Name = "textBoxPersonalAccessToken";
            textBoxPersonalAccessToken.Size = new Size(494, 23);
            textBoxPersonalAccessToken.TabIndex = 5;
            // 
            // numericUpDownDelay
            // 
            numericUpDownDelay.Dock = DockStyle.Top;
            numericUpDownDelay.Location = new Point(503, 173);
            numericUpDownDelay.Name = "numericUpDownDelay";
            numericUpDownDelay.Size = new Size(494, 23);
            numericUpDownDelay.TabIndex = 8;
            // 
            // tabPageQueries
            // 
            tabPageQueries.Controls.Add(tableLayoutPanelQueries);
            tabPageQueries.Location = new Point(4, 24);
            tabPageQueries.Name = "tabPageQueries";
            tabPageQueries.Padding = new Padding(3);
            tabPageQueries.Size = new Size(1256, 629);
            tabPageQueries.TabIndex = 1;
            tabPageQueries.Text = "Queries";
            tabPageQueries.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelQueries
            // 
            tableLayoutPanelQueries.ColumnCount = 2;
            tableLayoutPanelQueries.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelQueries.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelQueries.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanelQueries.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanelQueries.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanelQueries.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanelQueries.Dock = DockStyle.Fill;
            tableLayoutPanelQueries.Location = new Point(3, 3);
            tableLayoutPanelQueries.Name = "tableLayoutPanelQueries";
            tableLayoutPanelQueries.RowCount = 2;
            tableLayoutPanelQueries.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelQueries.RowStyles.Add(new RowStyle());
            tableLayoutPanelQueries.Size = new Size(1250, 623);
            tableLayoutPanelQueries.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(378, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(869, 44);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(118, 41);
            button3.TabIndex = 0;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(369, 567);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(369, 44);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 41);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(127, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 41);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(checkBox1, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(378, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(869, 567);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(217, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(204, 40);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 1;
            label2.Text = "Running";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(225, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 30);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(161, 100);
            label4.Name = "label4";
            label4.Size = new Size(95, 30);
            label4.TabIndex = 3;
            label4.Text = "RepositoryName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(218, 130);
            label5.Name = "label5";
            label5.Size = new Size(38, 437);
            label5.TabIndex = 4;
            label5.Text = "Filters";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(262, 133);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(515, 431);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button4);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(509, 24);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(118, 21);
            button4.TabIndex = 0;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(127, 3);
            button5.Name = "button5";
            button5.Size = new Size(118, 21);
            button5.TabIndex = 1;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 33);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(509, 567);
            dataGridView2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(262, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(515, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(262, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(515, 23);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(262, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(515, 23);
            comboBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Location = new Point(262, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(515, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1280, 720);
            Name = "EditForm";
            Text = "CSharp AzureDevopsNotifier";
            Load += EditForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageAzureDevOpsSettings.ResumeLayout(false);
            tableLayoutPanelAzureDevOpsSettings.ResumeLayout(false);
            tableLayoutPanelAzureDevOpsSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).EndInit();
            tabPageQueries.ResumeLayout(false);
            tableLayoutPanelQueries.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPageAzureDevOpsSettings;
        private TabPage tabPageQueries;
        private TableLayoutPanel tableLayoutPanelQueries;
        private TableLayoutPanel tableLayoutPanelAzureDevOpsSettings;
        private Label labelOrganizationUrl;
        private Label labelDelay;
        private Label labelProjectName;
        private Label labelPersonalAccessToken;
        private TextBox textBoxOrganizationUrl;
        private TextBox textBoxProjectName;
        private TextBox textBoxPersonalAccessToken;
        private NumericUpDown numericUpDownDelay;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
    }
}
