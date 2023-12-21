namespace BackPropagation
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
            groupBox1 = new GroupBox();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tbOutput = new TextBox();
            btnCreate = new Button();
            btnTrain = new Button();
            btnTest = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            lblHiddenNeurons = new Label();
            label10 = new Label();
            btnSetHiddenNeurons = new Button();
            tbHiddenNeurons = new TextBox();
            label6 = new Label();
            lblEpochs = new Label();
            label1 = new Label();
            btnSetEpochs = new Button();
            tbEpochs = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblEpochsPassed = new Label();
            label5 = new Label();
            tbTrainingData = new TextBox();
            btnReset = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveWeightsToolStripMenuItem = new ToolStripMenuItem();
            loadWeightsToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox3 = new GroupBox();
            btnTrainMore = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            epoch_15 = new Label();
            hidden_15 = new Label();
            max_15 = new Label();
            epoch_14 = new Label();
            hidden_14 = new Label();
            max_14 = new Label();
            epoch_13 = new Label();
            hidden_13 = new Label();
            max_13 = new Label();
            epoch_12 = new Label();
            hidden_12 = new Label();
            max_12 = new Label();
            epoch_11 = new Label();
            hidden_11 = new Label();
            max_11 = new Label();
            epoch_10 = new Label();
            hidden_10 = new Label();
            max_10 = new Label();
            epoch_9 = new Label();
            hidden_9 = new Label();
            max_9 = new Label();
            epoch_8 = new Label();
            hidden_8 = new Label();
            max_8 = new Label();
            epoch_7 = new Label();
            hidden_7 = new Label();
            max_7 = new Label();
            epoch_6 = new Label();
            hidden_6 = new Label();
            max_6 = new Label();
            epoch_5 = new Label();
            hidden_5 = new Label();
            max_5 = new Label();
            epoch_4 = new Label();
            hidden_4 = new Label();
            max_4 = new Label();
            epoch_3 = new Label();
            hidden_3 = new Label();
            max_3 = new Label();
            epoch_2 = new Label();
            hidden_2 = new Label();
            epoch_1 = new Label();
            hidden_1 = new Label();
            epoch_0 = new Label();
            hidden_0 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            label22 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            max_1 = new Label();
            max_2 = new Label();
            max_0 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label9 = new Label();
            btnTestAll = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(440, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inputs";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(216, 82);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 7;
            label13.Text = "Input 4: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(216, 42);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 6;
            label14.Text = "Input 3: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 82);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 5;
            label12.Text = "Input 2: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 40);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 4;
            label11.Text = "Input 1: ";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(270, 76);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(270, 36);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(60, 75);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(60, 36);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 0;
            // 
            // tbOutput
            // 
            tbOutput.BackColor = SystemColors.ButtonHighlight;
            tbOutput.Location = new Point(19, 339);
            tbOutput.Margin = new Padding(3, 2, 3, 2);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(246, 23);
            tbOutput.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(150, 133);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(116, 39);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create BPNN";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnTrain
            // 
            btnTrain.Enabled = false;
            btnTrain.Location = new Point(270, 85);
            btnTrain.Margin = new Padding(3, 2, 3, 2);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(150, 39);
            btnTrain.TabIndex = 3;
            btnTrain.Text = "Train Neural Network";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnTest
            // 
            btnTest.Enabled = false;
            btnTest.Location = new Point(59, 371);
            btnTest.Margin = new Padding(3, 2, 3, 2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(163, 23);
            btnTest.TabIndex = 4;
            btnTest.Text = "Test Current";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lblHiddenNeurons);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnSetHiddenNeurons);
            groupBox2.Controls.Add(tbHiddenNeurons);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblEpochs);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnSetEpochs);
            groupBox2.Controls.Add(btnTrain);
            groupBox2.Controls.Add(tbEpochs);
            groupBox2.Location = new Point(12, 317);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(440, 200);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Model Set-Up";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 28);
            label8.Name = "label8";
            label8.Size = new Size(158, 15);
            label8.TabIndex = 12;
            label8.Text = "Number of Hidden Neurons:";
            // 
            // lblHiddenNeurons
            // 
            lblHiddenNeurons.AutoSize = true;
            lblHiddenNeurons.Location = new Point(66, 82);
            lblHiddenNeurons.Name = "lblHiddenNeurons";
            lblHiddenNeurons.Size = new Size(13, 15);
            lblHiddenNeurons.TabIndex = 11;
            lblHiddenNeurons.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 82);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 9;
            label10.Text = "Current:";
            // 
            // btnSetHiddenNeurons
            // 
            btnSetHiddenNeurons.Location = new Point(195, 51);
            btnSetHiddenNeurons.Margin = new Padding(3, 2, 3, 2);
            btnSetHiddenNeurons.Name = "btnSetHiddenNeurons";
            btnSetHiddenNeurons.Size = new Size(48, 22);
            btnSetHiddenNeurons.TabIndex = 10;
            btnSetHiddenNeurons.Text = "Set ";
            btnSetHiddenNeurons.UseVisualStyleBackColor = true;
            btnSetHiddenNeurons.Click += btnSetHiddenNeurons_Click;
            // 
            // tbHiddenNeurons
            // 
            tbHiddenNeurons.Location = new Point(18, 51);
            tbHiddenNeurons.Margin = new Padding(3, 2, 3, 2);
            tbHiddenNeurons.Name = "tbHiddenNeurons";
            tbHiddenNeurons.Size = new Size(171, 23);
            tbHiddenNeurons.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 113);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 7;
            label6.Text = "Number of Training Epochs:";
            // 
            // lblEpochs
            // 
            lblEpochs.AutoSize = true;
            lblEpochs.Location = new Point(66, 165);
            lblEpochs.Name = "lblEpochs";
            lblEpochs.Size = new Size(13, 15);
            lblEpochs.TabIndex = 6;
            lblEpochs.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 165);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Current:";
            // 
            // btnSetEpochs
            // 
            btnSetEpochs.Enabled = false;
            btnSetEpochs.Location = new Point(195, 134);
            btnSetEpochs.Margin = new Padding(3, 2, 3, 2);
            btnSetEpochs.Name = "btnSetEpochs";
            btnSetEpochs.Size = new Size(48, 22);
            btnSetEpochs.TabIndex = 5;
            btnSetEpochs.Text = "Set ";
            btnSetEpochs.UseVisualStyleBackColor = true;
            btnSetEpochs.Click += btnSetEpochs_Click;
            // 
            // tbEpochs
            // 
            tbEpochs.Enabled = false;
            tbEpochs.Location = new Point(18, 134);
            tbEpochs.Margin = new Padding(3, 2, 3, 2);
            tbEpochs.Name = "tbEpochs";
            tbEpochs.Size = new Size(171, 23);
            tbEpochs.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(313, 36);
            label3.TabIndex = 6;
            label3.Text = "4 - Input AND GATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 417);
            label4.Name = "label4";
            label4.Size = new Size(193, 15);
            label4.TabIndex = 7;
            label4.Text = "Number of Training Epochs Passed:";
            // 
            // lblEpochsPassed
            // 
            lblEpochsPassed.AutoSize = true;
            lblEpochsPassed.Location = new Point(651, 417);
            lblEpochsPassed.Name = "lblEpochsPassed";
            lblEpochsPassed.Size = new Size(13, 15);
            lblEpochsPassed.TabIndex = 8;
            lblEpochsPassed.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 36);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "Training Data";
            // 
            // tbTrainingData
            // 
            tbTrainingData.BackColor = SystemColors.ButtonHighlight;
            tbTrainingData.Location = new Point(19, 71);
            tbTrainingData.Margin = new Padding(3, 2, 3, 2);
            tbTrainingData.Multiline = true;
            tbTrainingData.Name = "tbTrainingData";
            tbTrainingData.ReadOnly = true;
            tbTrainingData.ScrollBars = ScrollBars.Vertical;
            tbTrainingData.Size = new Size(246, 236);
            tbTrainingData.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(162, 544);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 38);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset Model";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(1193, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveWeightsToolStripMenuItem, loadWeightsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveWeightsToolStripMenuItem
            // 
            saveWeightsToolStripMenuItem.Name = "saveWeightsToolStripMenuItem";
            saveWeightsToolStripMenuItem.Size = new Size(180, 22);
            saveWeightsToolStripMenuItem.Text = "Save Weights";
            saveWeightsToolStripMenuItem.Click += saveWeightsToolStripMenuItem_Click;
            // 
            // loadWeightsToolStripMenuItem
            // 
            loadWeightsToolStripMenuItem.Name = "loadWeightsToolStripMenuItem";
            loadWeightsToolStripMenuItem.Size = new Size(180, 22);
            loadWeightsToolStripMenuItem.Text = "Load Weights";
            loadWeightsToolStripMenuItem.Click += loadWeightsToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTrainMore);
            groupBox3.Controls.Add(lblEpochsPassed);
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnTestAll);
            groupBox3.Controls.Add(btnTest);
            groupBox3.Controls.Add(tbOutput);
            groupBox3.Controls.Add(tbTrainingData);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(472, 88);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(698, 466);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Output";
            // 
            // btnTrainMore
            // 
            btnTrainMore.Enabled = false;
            btnTrainMore.Location = new Point(101, 29);
            btnTrainMore.Name = "btnTrainMore";
            btnTrainMore.Size = new Size(69, 34);
            btnTrainMore.TabIndex = 26;
            btnTrainMore.Text = "Train";
            btnTrainMore.UseVisualStyleBackColor = true;
            btnTrainMore.Click += btnTrainMore_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Controls.Add(epoch_15, 3, 15);
            tableLayoutPanel1.Controls.Add(hidden_15, 2, 15);
            tableLayoutPanel1.Controls.Add(max_15, 1, 15);
            tableLayoutPanel1.Controls.Add(epoch_14, 3, 14);
            tableLayoutPanel1.Controls.Add(hidden_14, 2, 14);
            tableLayoutPanel1.Controls.Add(max_14, 1, 14);
            tableLayoutPanel1.Controls.Add(epoch_13, 3, 13);
            tableLayoutPanel1.Controls.Add(hidden_13, 2, 13);
            tableLayoutPanel1.Controls.Add(max_13, 1, 13);
            tableLayoutPanel1.Controls.Add(epoch_12, 3, 12);
            tableLayoutPanel1.Controls.Add(hidden_12, 2, 12);
            tableLayoutPanel1.Controls.Add(max_12, 1, 12);
            tableLayoutPanel1.Controls.Add(epoch_11, 3, 11);
            tableLayoutPanel1.Controls.Add(hidden_11, 2, 11);
            tableLayoutPanel1.Controls.Add(max_11, 1, 11);
            tableLayoutPanel1.Controls.Add(epoch_10, 3, 10);
            tableLayoutPanel1.Controls.Add(hidden_10, 2, 10);
            tableLayoutPanel1.Controls.Add(max_10, 1, 10);
            tableLayoutPanel1.Controls.Add(epoch_9, 3, 9);
            tableLayoutPanel1.Controls.Add(hidden_9, 2, 9);
            tableLayoutPanel1.Controls.Add(max_9, 1, 9);
            tableLayoutPanel1.Controls.Add(epoch_8, 3, 8);
            tableLayoutPanel1.Controls.Add(hidden_8, 2, 8);
            tableLayoutPanel1.Controls.Add(max_8, 1, 8);
            tableLayoutPanel1.Controls.Add(epoch_7, 3, 7);
            tableLayoutPanel1.Controls.Add(hidden_7, 2, 7);
            tableLayoutPanel1.Controls.Add(max_7, 1, 7);
            tableLayoutPanel1.Controls.Add(epoch_6, 3, 6);
            tableLayoutPanel1.Controls.Add(hidden_6, 2, 6);
            tableLayoutPanel1.Controls.Add(max_6, 1, 6);
            tableLayoutPanel1.Controls.Add(epoch_5, 3, 5);
            tableLayoutPanel1.Controls.Add(hidden_5, 2, 5);
            tableLayoutPanel1.Controls.Add(max_5, 1, 5);
            tableLayoutPanel1.Controls.Add(epoch_4, 3, 4);
            tableLayoutPanel1.Controls.Add(hidden_4, 2, 4);
            tableLayoutPanel1.Controls.Add(max_4, 1, 4);
            tableLayoutPanel1.Controls.Add(epoch_3, 3, 3);
            tableLayoutPanel1.Controls.Add(hidden_3, 2, 3);
            tableLayoutPanel1.Controls.Add(max_3, 1, 3);
            tableLayoutPanel1.Controls.Add(epoch_2, 3, 2);
            tableLayoutPanel1.Controls.Add(hidden_2, 2, 2);
            tableLayoutPanel1.Controls.Add(epoch_1, 3, 1);
            tableLayoutPanel1.Controls.Add(hidden_1, 2, 1);
            tableLayoutPanel1.Controls.Add(epoch_0, 3, 0);
            tableLayoutPanel1.Controls.Add(hidden_0, 2, 0);
            tableLayoutPanel1.Controls.Add(label19, 0, 0);
            tableLayoutPanel1.Controls.Add(label20, 0, 1);
            tableLayoutPanel1.Controls.Add(label21, 0, 2);
            tableLayoutPanel1.Controls.Add(label23, 0, 4);
            tableLayoutPanel1.Controls.Add(label22, 0, 3);
            tableLayoutPanel1.Controls.Add(label24, 0, 5);
            tableLayoutPanel1.Controls.Add(label25, 0, 6);
            tableLayoutPanel1.Controls.Add(label26, 0, 7);
            tableLayoutPanel1.Controls.Add(label27, 0, 8);
            tableLayoutPanel1.Controls.Add(label28, 0, 9);
            tableLayoutPanel1.Controls.Add(label29, 0, 10);
            tableLayoutPanel1.Controls.Add(label30, 0, 11);
            tableLayoutPanel1.Controls.Add(label31, 0, 12);
            tableLayoutPanel1.Controls.Add(label32, 0, 13);
            tableLayoutPanel1.Controls.Add(label33, 0, 14);
            tableLayoutPanel1.Controls.Add(label34, 0, 15);
            tableLayoutPanel1.Controls.Add(max_1, 1, 1);
            tableLayoutPanel1.Controls.Add(max_2, 1, 2);
            tableLayoutPanel1.Controls.Add(max_0, 1, 0);
            tableLayoutPanel1.Location = new Point(293, 71);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.Size = new Size(362, 331);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // epoch_15
            // 
            epoch_15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_15.AutoSize = true;
            epoch_15.BackColor = SystemColors.GradientInactiveCaption;
            epoch_15.Location = new Point(290, 300);
            epoch_15.Name = "epoch_15";
            epoch_15.Size = new Size(70, 31);
            epoch_15.TabIndex = 63;
            epoch_15.Text = "0";
            epoch_15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_15
            // 
            hidden_15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_15.AutoSize = true;
            hidden_15.BackColor = SystemColors.GradientInactiveCaption;
            hidden_15.Location = new Point(160, 300);
            hidden_15.Name = "hidden_15";
            hidden_15.Size = new Size(124, 31);
            hidden_15.TabIndex = 62;
            hidden_15.Text = "0";
            hidden_15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_15
            // 
            max_15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_15.AutoSize = true;
            max_15.BackColor = SystemColors.GradientInactiveCaption;
            max_15.Location = new Point(54, 300);
            max_15.Name = "max_15";
            max_15.Size = new Size(100, 31);
            max_15.TabIndex = 61;
            max_15.Text = "0";
            max_15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_14
            // 
            epoch_14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_14.AutoSize = true;
            epoch_14.BackColor = SystemColors.ActiveCaption;
            epoch_14.Location = new Point(290, 280);
            epoch_14.Name = "epoch_14";
            epoch_14.Size = new Size(70, 20);
            epoch_14.TabIndex = 60;
            epoch_14.Text = "0";
            epoch_14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_14
            // 
            hidden_14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_14.AutoSize = true;
            hidden_14.BackColor = SystemColors.ActiveCaption;
            hidden_14.Location = new Point(160, 280);
            hidden_14.Name = "hidden_14";
            hidden_14.Size = new Size(124, 20);
            hidden_14.TabIndex = 59;
            hidden_14.Text = "0";
            hidden_14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_14
            // 
            max_14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_14.AutoSize = true;
            max_14.BackColor = SystemColors.ActiveCaption;
            max_14.Location = new Point(54, 280);
            max_14.Name = "max_14";
            max_14.Size = new Size(100, 20);
            max_14.TabIndex = 58;
            max_14.Text = "0";
            max_14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_13
            // 
            epoch_13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_13.AutoSize = true;
            epoch_13.BackColor = SystemColors.GradientInactiveCaption;
            epoch_13.Location = new Point(290, 260);
            epoch_13.Name = "epoch_13";
            epoch_13.Size = new Size(70, 20);
            epoch_13.TabIndex = 57;
            epoch_13.Text = "0";
            epoch_13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_13
            // 
            hidden_13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_13.AutoSize = true;
            hidden_13.BackColor = SystemColors.GradientInactiveCaption;
            hidden_13.Location = new Point(160, 260);
            hidden_13.Name = "hidden_13";
            hidden_13.Size = new Size(124, 20);
            hidden_13.TabIndex = 56;
            hidden_13.Text = "0";
            hidden_13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_13
            // 
            max_13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_13.AutoSize = true;
            max_13.BackColor = SystemColors.GradientInactiveCaption;
            max_13.Location = new Point(54, 260);
            max_13.Name = "max_13";
            max_13.Size = new Size(100, 20);
            max_13.TabIndex = 55;
            max_13.Text = "0";
            max_13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_12
            // 
            epoch_12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_12.AutoSize = true;
            epoch_12.BackColor = SystemColors.ActiveCaption;
            epoch_12.Location = new Point(290, 240);
            epoch_12.Name = "epoch_12";
            epoch_12.Size = new Size(70, 20);
            epoch_12.TabIndex = 54;
            epoch_12.Text = "0";
            epoch_12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_12
            // 
            hidden_12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_12.AutoSize = true;
            hidden_12.BackColor = SystemColors.ActiveCaption;
            hidden_12.Location = new Point(160, 240);
            hidden_12.Name = "hidden_12";
            hidden_12.Size = new Size(124, 20);
            hidden_12.TabIndex = 53;
            hidden_12.Text = "0";
            hidden_12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_12
            // 
            max_12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_12.AutoSize = true;
            max_12.BackColor = SystemColors.ActiveCaption;
            max_12.Location = new Point(54, 240);
            max_12.Name = "max_12";
            max_12.Size = new Size(100, 20);
            max_12.TabIndex = 52;
            max_12.Text = "0";
            max_12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_11
            // 
            epoch_11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_11.AutoSize = true;
            epoch_11.BackColor = SystemColors.GradientInactiveCaption;
            epoch_11.Location = new Point(290, 220);
            epoch_11.Name = "epoch_11";
            epoch_11.Size = new Size(70, 20);
            epoch_11.TabIndex = 51;
            epoch_11.Text = "0";
            epoch_11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_11
            // 
            hidden_11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_11.AutoSize = true;
            hidden_11.BackColor = SystemColors.GradientInactiveCaption;
            hidden_11.Location = new Point(160, 220);
            hidden_11.Name = "hidden_11";
            hidden_11.Size = new Size(124, 20);
            hidden_11.TabIndex = 50;
            hidden_11.Text = "0";
            hidden_11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_11
            // 
            max_11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_11.AutoSize = true;
            max_11.BackColor = SystemColors.GradientInactiveCaption;
            max_11.Location = new Point(54, 220);
            max_11.Name = "max_11";
            max_11.Size = new Size(100, 20);
            max_11.TabIndex = 49;
            max_11.Text = "0";
            max_11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_10
            // 
            epoch_10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_10.AutoSize = true;
            epoch_10.BackColor = SystemColors.ActiveCaption;
            epoch_10.Location = new Point(290, 200);
            epoch_10.Name = "epoch_10";
            epoch_10.Size = new Size(70, 20);
            epoch_10.TabIndex = 48;
            epoch_10.Text = "0";
            epoch_10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_10
            // 
            hidden_10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_10.AutoSize = true;
            hidden_10.BackColor = SystemColors.ActiveCaption;
            hidden_10.Location = new Point(160, 200);
            hidden_10.Name = "hidden_10";
            hidden_10.Size = new Size(124, 20);
            hidden_10.TabIndex = 47;
            hidden_10.Text = "0";
            hidden_10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_10
            // 
            max_10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_10.AutoSize = true;
            max_10.BackColor = SystemColors.ActiveCaption;
            max_10.Location = new Point(54, 200);
            max_10.Name = "max_10";
            max_10.Size = new Size(100, 20);
            max_10.TabIndex = 46;
            max_10.Text = "0";
            max_10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_9
            // 
            epoch_9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_9.AutoSize = true;
            epoch_9.BackColor = SystemColors.GradientInactiveCaption;
            epoch_9.Location = new Point(290, 180);
            epoch_9.Name = "epoch_9";
            epoch_9.Size = new Size(70, 20);
            epoch_9.TabIndex = 45;
            epoch_9.Text = "0";
            epoch_9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_9
            // 
            hidden_9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_9.AutoSize = true;
            hidden_9.BackColor = SystemColors.GradientInactiveCaption;
            hidden_9.Location = new Point(160, 180);
            hidden_9.Name = "hidden_9";
            hidden_9.Size = new Size(124, 20);
            hidden_9.TabIndex = 44;
            hidden_9.Text = "0";
            hidden_9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_9
            // 
            max_9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_9.AutoSize = true;
            max_9.BackColor = SystemColors.GradientInactiveCaption;
            max_9.Location = new Point(54, 180);
            max_9.Name = "max_9";
            max_9.Size = new Size(100, 20);
            max_9.TabIndex = 43;
            max_9.Text = "0";
            max_9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_8
            // 
            epoch_8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_8.AutoSize = true;
            epoch_8.BackColor = SystemColors.ActiveCaption;
            epoch_8.Location = new Point(290, 160);
            epoch_8.Name = "epoch_8";
            epoch_8.Size = new Size(70, 20);
            epoch_8.TabIndex = 42;
            epoch_8.Text = "0";
            epoch_8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_8
            // 
            hidden_8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_8.AutoSize = true;
            hidden_8.BackColor = SystemColors.ActiveCaption;
            hidden_8.Location = new Point(160, 160);
            hidden_8.Name = "hidden_8";
            hidden_8.Size = new Size(124, 20);
            hidden_8.TabIndex = 41;
            hidden_8.Text = "0";
            hidden_8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_8
            // 
            max_8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_8.AutoSize = true;
            max_8.BackColor = SystemColors.ActiveCaption;
            max_8.Location = new Point(54, 160);
            max_8.Name = "max_8";
            max_8.Size = new Size(100, 20);
            max_8.TabIndex = 40;
            max_8.Text = "0";
            max_8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_7
            // 
            epoch_7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_7.AutoSize = true;
            epoch_7.BackColor = SystemColors.GradientInactiveCaption;
            epoch_7.Location = new Point(290, 140);
            epoch_7.Name = "epoch_7";
            epoch_7.Size = new Size(70, 20);
            epoch_7.TabIndex = 39;
            epoch_7.Text = "0";
            epoch_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_7
            // 
            hidden_7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_7.AutoSize = true;
            hidden_7.BackColor = SystemColors.GradientInactiveCaption;
            hidden_7.Location = new Point(160, 140);
            hidden_7.Name = "hidden_7";
            hidden_7.Size = new Size(124, 20);
            hidden_7.TabIndex = 38;
            hidden_7.Text = "0";
            hidden_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_7
            // 
            max_7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_7.AutoSize = true;
            max_7.BackColor = SystemColors.GradientInactiveCaption;
            max_7.Location = new Point(54, 140);
            max_7.Name = "max_7";
            max_7.Size = new Size(100, 20);
            max_7.TabIndex = 37;
            max_7.Text = "0";
            max_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_6
            // 
            epoch_6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_6.AutoSize = true;
            epoch_6.BackColor = SystemColors.ActiveCaption;
            epoch_6.Location = new Point(290, 120);
            epoch_6.Name = "epoch_6";
            epoch_6.Size = new Size(70, 20);
            epoch_6.TabIndex = 36;
            epoch_6.Text = "0";
            epoch_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_6
            // 
            hidden_6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_6.AutoSize = true;
            hidden_6.BackColor = SystemColors.ActiveCaption;
            hidden_6.Location = new Point(160, 120);
            hidden_6.Name = "hidden_6";
            hidden_6.Size = new Size(124, 20);
            hidden_6.TabIndex = 35;
            hidden_6.Text = "0";
            hidden_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_6
            // 
            max_6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_6.AutoSize = true;
            max_6.BackColor = SystemColors.ActiveCaption;
            max_6.Location = new Point(54, 120);
            max_6.Name = "max_6";
            max_6.Size = new Size(100, 20);
            max_6.TabIndex = 34;
            max_6.Text = "0";
            max_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_5
            // 
            epoch_5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_5.AutoSize = true;
            epoch_5.BackColor = SystemColors.GradientInactiveCaption;
            epoch_5.Location = new Point(290, 100);
            epoch_5.Name = "epoch_5";
            epoch_5.Size = new Size(70, 20);
            epoch_5.TabIndex = 33;
            epoch_5.Text = "0";
            epoch_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_5
            // 
            hidden_5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_5.AutoSize = true;
            hidden_5.BackColor = SystemColors.GradientInactiveCaption;
            hidden_5.Location = new Point(160, 100);
            hidden_5.Name = "hidden_5";
            hidden_5.Size = new Size(124, 20);
            hidden_5.TabIndex = 32;
            hidden_5.Text = "0";
            hidden_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_5
            // 
            max_5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_5.AutoSize = true;
            max_5.BackColor = SystemColors.GradientInactiveCaption;
            max_5.Location = new Point(54, 100);
            max_5.Name = "max_5";
            max_5.Size = new Size(100, 20);
            max_5.TabIndex = 31;
            max_5.Text = "0";
            max_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_4
            // 
            epoch_4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_4.AutoSize = true;
            epoch_4.BackColor = SystemColors.ActiveCaption;
            epoch_4.Location = new Point(290, 80);
            epoch_4.Name = "epoch_4";
            epoch_4.Size = new Size(70, 20);
            epoch_4.TabIndex = 30;
            epoch_4.Text = "0";
            epoch_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_4
            // 
            hidden_4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_4.AutoSize = true;
            hidden_4.BackColor = SystemColors.ActiveCaption;
            hidden_4.Location = new Point(160, 80);
            hidden_4.Name = "hidden_4";
            hidden_4.Size = new Size(124, 20);
            hidden_4.TabIndex = 29;
            hidden_4.Text = "0";
            hidden_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_4
            // 
            max_4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_4.AutoSize = true;
            max_4.BackColor = SystemColors.ActiveCaption;
            max_4.Location = new Point(54, 80);
            max_4.Name = "max_4";
            max_4.Size = new Size(100, 20);
            max_4.TabIndex = 28;
            max_4.Text = "0";
            max_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_3
            // 
            epoch_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_3.AutoSize = true;
            epoch_3.BackColor = SystemColors.GradientInactiveCaption;
            epoch_3.Location = new Point(290, 60);
            epoch_3.Name = "epoch_3";
            epoch_3.Size = new Size(70, 20);
            epoch_3.TabIndex = 27;
            epoch_3.Text = "0";
            epoch_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_3
            // 
            hidden_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_3.AutoSize = true;
            hidden_3.BackColor = SystemColors.GradientInactiveCaption;
            hidden_3.Location = new Point(160, 60);
            hidden_3.Name = "hidden_3";
            hidden_3.Size = new Size(124, 20);
            hidden_3.TabIndex = 26;
            hidden_3.Text = "0";
            hidden_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_3
            // 
            max_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_3.AutoSize = true;
            max_3.BackColor = SystemColors.GradientInactiveCaption;
            max_3.Location = new Point(54, 60);
            max_3.Name = "max_3";
            max_3.Size = new Size(100, 20);
            max_3.TabIndex = 25;
            max_3.Text = "0";
            max_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_2
            // 
            epoch_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_2.AutoSize = true;
            epoch_2.BackColor = SystemColors.ActiveCaption;
            epoch_2.Location = new Point(290, 40);
            epoch_2.Name = "epoch_2";
            epoch_2.Size = new Size(70, 20);
            epoch_2.TabIndex = 24;
            epoch_2.Text = "0";
            epoch_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_2
            // 
            hidden_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_2.AutoSize = true;
            hidden_2.BackColor = SystemColors.ActiveCaption;
            hidden_2.Location = new Point(160, 40);
            hidden_2.Name = "hidden_2";
            hidden_2.Size = new Size(124, 20);
            hidden_2.TabIndex = 23;
            hidden_2.Text = "0";
            hidden_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_1
            // 
            epoch_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_1.AutoSize = true;
            epoch_1.BackColor = SystemColors.GradientInactiveCaption;
            epoch_1.Location = new Point(290, 20);
            epoch_1.Name = "epoch_1";
            epoch_1.Size = new Size(70, 20);
            epoch_1.TabIndex = 22;
            epoch_1.Text = "0";
            epoch_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_1
            // 
            hidden_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_1.AutoSize = true;
            hidden_1.BackColor = SystemColors.GradientInactiveCaption;
            hidden_1.Location = new Point(160, 20);
            hidden_1.Name = "hidden_1";
            hidden_1.Size = new Size(124, 20);
            hidden_1.TabIndex = 21;
            hidden_1.Text = "0";
            hidden_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epoch_0
            // 
            epoch_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            epoch_0.AutoSize = true;
            epoch_0.BackColor = SystemColors.ActiveCaption;
            epoch_0.Location = new Point(290, 0);
            epoch_0.Name = "epoch_0";
            epoch_0.Size = new Size(70, 20);
            epoch_0.TabIndex = 20;
            epoch_0.Text = "0";
            epoch_0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hidden_0
            // 
            hidden_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hidden_0.AutoSize = true;
            hidden_0.BackColor = SystemColors.ActiveCaption;
            hidden_0.Location = new Point(160, 0);
            hidden_0.Name = "hidden_0";
            hidden_0.Size = new Size(124, 20);
            hidden_0.TabIndex = 19;
            hidden_0.Text = "0";
            hidden_0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = SystemColors.ActiveCaption;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(45, 20);
            label19.TabIndex = 0;
            label19.Text = "0000";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = SystemColors.GradientInactiveCaption;
            label20.Location = new Point(3, 20);
            label20.Name = "label20";
            label20.Size = new Size(45, 20);
            label20.TabIndex = 1;
            label20.Text = "0001";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ActiveCaption;
            label21.Location = new Point(3, 40);
            label21.Name = "label21";
            label21.Size = new Size(45, 20);
            label21.TabIndex = 2;
            label21.Text = "0010";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.BackColor = SystemColors.ActiveCaption;
            label23.Location = new Point(3, 80);
            label23.Name = "label23";
            label23.Size = new Size(45, 20);
            label23.TabIndex = 4;
            label23.Text = "0100";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.BackColor = SystemColors.GradientInactiveCaption;
            label22.Location = new Point(3, 60);
            label22.Name = "label22";
            label22.Size = new Size(45, 20);
            label22.TabIndex = 3;
            label22.Text = "0011";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.BackColor = SystemColors.GradientInactiveCaption;
            label24.Location = new Point(3, 100);
            label24.Name = "label24";
            label24.Size = new Size(45, 20);
            label24.TabIndex = 5;
            label24.Text = "0101";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.BackColor = SystemColors.ActiveCaption;
            label25.Location = new Point(3, 120);
            label25.Name = "label25";
            label25.Size = new Size(45, 20);
            label25.TabIndex = 6;
            label25.Text = "0110";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.BackColor = SystemColors.GradientInactiveCaption;
            label26.Location = new Point(3, 140);
            label26.Name = "label26";
            label26.Size = new Size(45, 20);
            label26.TabIndex = 7;
            label26.Text = "0111";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.BackColor = SystemColors.ActiveCaption;
            label27.Location = new Point(3, 160);
            label27.Name = "label27";
            label27.Size = new Size(45, 20);
            label27.TabIndex = 8;
            label27.Text = "1000";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.BackColor = SystemColors.GradientInactiveCaption;
            label28.Location = new Point(3, 180);
            label28.Name = "label28";
            label28.Size = new Size(45, 20);
            label28.TabIndex = 9;
            label28.Text = "1001";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.BackColor = SystemColors.ActiveCaption;
            label29.Location = new Point(3, 200);
            label29.Name = "label29";
            label29.Size = new Size(45, 20);
            label29.TabIndex = 10;
            label29.Text = "1010";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.BackColor = SystemColors.GradientInactiveCaption;
            label30.Location = new Point(3, 220);
            label30.Name = "label30";
            label30.Size = new Size(45, 20);
            label30.TabIndex = 11;
            label30.Text = "1011";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.BackColor = SystemColors.ActiveCaption;
            label31.Location = new Point(3, 240);
            label31.Name = "label31";
            label31.Size = new Size(45, 20);
            label31.TabIndex = 12;
            label31.Text = "1100";
            label31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label32.AutoSize = true;
            label32.BackColor = SystemColors.GradientInactiveCaption;
            label32.Location = new Point(3, 260);
            label32.Name = "label32";
            label32.Size = new Size(45, 20);
            label32.TabIndex = 13;
            label32.Text = "1101";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label33.AutoSize = true;
            label33.BackColor = SystemColors.ActiveCaption;
            label33.Location = new Point(3, 280);
            label33.Name = "label33";
            label33.Size = new Size(45, 20);
            label33.TabIndex = 14;
            label33.Text = "1110";
            label33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.BackColor = SystemColors.GradientInactiveCaption;
            label34.Location = new Point(3, 300);
            label34.Name = "label34";
            label34.Size = new Size(45, 31);
            label34.TabIndex = 15;
            label34.Text = "1111";
            label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_1
            // 
            max_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_1.AutoSize = true;
            max_1.BackColor = SystemColors.GradientInactiveCaption;
            max_1.Location = new Point(54, 20);
            max_1.Name = "max_1";
            max_1.Size = new Size(100, 20);
            max_1.TabIndex = 17;
            max_1.Text = "0";
            max_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_2
            // 
            max_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_2.AutoSize = true;
            max_2.BackColor = SystemColors.ActiveCaption;
            max_2.Location = new Point(54, 40);
            max_2.Name = "max_2";
            max_2.Size = new Size(100, 20);
            max_2.TabIndex = 18;
            max_2.Text = "0";
            max_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_0
            // 
            max_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            max_0.AutoSize = true;
            max_0.BackColor = SystemColors.ActiveCaption;
            max_0.Location = new Point(54, 0);
            max_0.Name = "max_0";
            max_0.Size = new Size(100, 20);
            max_0.TabIndex = 16;
            max_0.Text = "0";
            max_0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(588, 41);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 20;
            label18.Text = "# of Epochs";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(458, 41);
            label17.Name = "label17";
            label17.Size = new Size(118, 15);
            label17.TabIndex = 19;
            label17.Text = "# of Hidden Neurons";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(359, 41);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 18;
            label16.Text = "Actual Output";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(292, 41);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 17;
            label9.Text = "Input";
            // 
            // btnTestAll
            // 
            btnTestAll.Enabled = false;
            btnTestAll.Location = new Point(59, 403);
            btnTestAll.Margin = new Padding(3, 2, 3, 2);
            btnTestAll.Name = "btnTestAll";
            btnTestAll.Size = new Size(163, 26);
            btnTestAll.TabIndex = 16;
            btnTestAll.Text = "Test All";
            btnTestAll.UseVisualStyleBackColor = true;
            btnTestAll.Click += btnTestAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1193, 612);
            Controls.Add(groupBox3);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox tbOutput;
        private Button btnCreate;
        private Button btnTrain;
        private Button btnTest;
        private GroupBox groupBox2;
        private Button btnSetEpochs;
        private TextBox tbEpochs;
        private Label lblEpochs;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblEpochsPassed;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox tbTrainingData;
        private Label label6;
        private Label label8;
        private Label lblHiddenNeurons;
        private Label label10;
        private Button btnSetHiddenNeurons;
        private TextBox tbHiddenNeurons;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label11;
        private Button btnReset;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveWeightsToolStripMenuItem;
        private ToolStripMenuItem loadWeightsToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox3;
        private Button btnTestAll;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label9;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label22;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label max_1;
        private Label max_2;
        private Label max_0;
        private Label epoch_15;
        private Label hidden_15;
        private Label max_15;
        private Label epoch_14;
        private Label hidden_14;
        private Label max_14;
        private Label epoch_13;
        private Label hidden_13;
        private Label max_13;
        private Label epoch_12;
        private Label hidden_12;
        private Label max_12;
        private Label epoch_11;
        private Label hidden_11;
        private Label max_11;
        private Label epoch_10;
        private Label hidden_10;
        private Label max_10;
        private Label epoch_9;
        private Label hidden_9;
        private Label max_9;
        private Label epoch_8;
        private Label hidden_8;
        private Label max_8;
        private Label epoch_7;
        private Label hidden_7;
        private Label max_7;
        private Label epoch_6;
        private Label hidden_6;
        private Label max_6;
        private Label epoch_5;
        private Label hidden_5;
        private Label max_5;
        private Label epoch_4;
        private Label hidden_4;
        private Label max_4;
        private Label epoch_3;
        private Label hidden_3;
        private Label max_3;
        private Label epoch_2;
        private Label hidden_2;
        private Label epoch_1;
        private Label hidden_1;
        private Label epoch_0;
        private Label hidden_0;
        private Button btnTrainMore;
    }
}

