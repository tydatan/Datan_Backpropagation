using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        bool nn_created;
        int inputs;
        int data;
        int hidden_neurons;
        int training_iterations;
        int epochs_passed;
        bool printed;
        bool trained;
        int[] desired_output;
        Label[] actual;
        Label[] hidden;
        Label[] epochs;

        // HELPER METHOD
        static string ConvertToBinary(int number, int bits)
        {
            string binary = Convert.ToString(number, 2);

            if (binary.Length < bits)
            {
                binary = binary.PadLeft(bits, '0');
            }
            return binary;
        }

        public Form1()
        {
            InitializeComponent();
            nn_created = false;
            inputs = 4;
            data = Convert.ToInt16(Math.Pow(2, inputs));
            hidden_neurons = 0;
            training_iterations = 0;
            epochs_passed = 0;
            printed = false;

            desired_output = new int[]
            {
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,0,0,1
            };
            actual = new Label[]
            {
                max_0, max_1, max_2, max_3, max_4, max_5,
                max_6, max_7, max_8, max_9, max_10,max_11,
                max_12, max_13, max_14, max_15
            };
            hidden = new Label[]
            {
                hidden_0,hidden_1,hidden_2,hidden_3,
                hidden_4,hidden_5,hidden_6,hidden_7,
                hidden_8,hidden_9,hidden_10,hidden_11,
                hidden_12,hidden_13,hidden_14,hidden_15
            };
            epochs = new Label[]
            {
                epoch_0, epoch_1, epoch_2, epoch_3, epoch_4, epoch_5,
                epoch_6, epoch_7, epoch_8, epoch_9, epoch_10,
                epoch_11, epoch_12, epoch_13, epoch_14, epoch_15
            };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!nn_created)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                nn_created = true;
                btnCreate.Enabled = false;

                tbHiddenNeurons.Enabled = false;
                btnSetHiddenNeurons.Enabled = false;
                lblHiddenNeurons.Text = "" + hidden_neurons;

                tbEpochs.Enabled = true;
                btnSetEpochs.Enabled = true;
                training_iterations = 1;
                lblEpochs.Text = "" + training_iterations;

                btnTrain.Enabled = true;
                btnReset.Enabled = true;
                btnTrainMore.Enabled = true;

                nn = new NeuralNet(inputs, hidden_neurons, 1);
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            btnTest.Enabled = true;
            btnTestAll.Enabled = true;
            train();
        }

        private void train()
        {
            for (int i = 0; i < training_iterations; i++)
            {
                for (int n = 0; n < data; n++)
                {
                    string binary = ConvertToBinary(n, 4);
                    string i1 = binary[0].ToString();
                    string i2 = binary[1].ToString();
                    string i3 = binary[2].ToString();
                    string i4 = binary[3].ToString();

                    if (n == 15)
                    {
                        nn.setInputs(0, 1.0);
                        nn.setInputs(1, 1.0);
                        nn.setInputs(2, 1.0);
                        nn.setInputs(3, 1.0);
                        nn.setDesiredOutput(0, 1.0);
                        if (!printed)
                        {
                            tbTrainingData.Text += n + 1 + " - Data: " + binary + "   Output: 1" + Environment.NewLine;
                        }
                    }
                    else
                    {
                        nn.setInputs(0, Convert.ToDouble(i1));
                        nn.setInputs(1, Convert.ToDouble(i2));
                        nn.setInputs(2, Convert.ToDouble(i3));
                        nn.setInputs(3, Convert.ToDouble(i4));
                        nn.setDesiredOutput(0, 0.0);
                        if (!printed)
                        {
                            actual[n].Text = "1";
                            tbTrainingData.Text += n + 1 + " - Data: " + binary + "   Output: 0" + Environment.NewLine;
                        }
                    }
                    nn.learn();
                }
                printed = true;
                epochs_passed++;
                lblEpochsPassed.Text = "" + epochs_passed;
            }
        }

        private void btnSetHiddenNeurons_Click(object sender, EventArgs e)
        {
            if (tbHiddenNeurons.Text == "")
                return;

            int h_n = Convert.ToInt16(tbHiddenNeurons.Text);
            if (h_n > 0)
            {
                hidden_neurons = h_n;
                lblHiddenNeurons.Text = tbHiddenNeurons.Text;
                tbHiddenNeurons.Text = "";
            }

        }

        private void btnSetEpochs_Click(object sender, EventArgs e)
        {
            if (tbEpochs.Text == "")
                return;

            int iterations = Convert.ToInt16(tbEpochs.Text);
            if (iterations > 0)
            {
                training_iterations = iterations;
                lblEpochs.Text = tbEpochs.Text;
                tbEpochs.Text = "";
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                return;

            string i1 = textBox1.Text;
            string i2 = textBox2.Text;
            string i3 = textBox3.Text;
            string i4 = textBox4.Text;
            nn.setInputs(0, Convert.ToDouble(i1));
            nn.setInputs(1, Convert.ToDouble(i2));
            nn.setInputs(2, Convert.ToDouble(i3));
            nn.setInputs(3, Convert.ToDouble(i4));
            nn.run();
            double output = nn.getOuputData(0);
            tbOutput.Text = output.ToString("F11");

            string input = i1 + i2 + i3 + i4;
            int value = Convert.ToInt16(input, 2);

            for (int i = 0; i < data; i++)
            {
                if (value == i)
                {
                    double act = Convert.ToDouble(actual[i].Text);
                    int desired = desired_output[i];
                    if (desired == 0)
                    {
                        if (output < act)
                        {
                            actual[i].Text = output.ToString("F11");
                            hidden[i].Text = "" + hidden_neurons;
                            epochs[i].Text = "" + epochs_passed;
                        }
                    }
                    else
                    {
                        if (output > act)
                        {
                            actual[i].Text = output.ToString("F11");
                            hidden[i].Text = "" + hidden_neurons;
                            epochs[i].Text = "" + epochs_passed;
                        }
                    }
                }
            }
        }

        private void btnTestAll_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < data; n++)
            {
                string binary = ConvertToBinary(n, 4);
                nn.setInputs(0, Convert.ToDouble(binary[0].ToString()));
                nn.setInputs(1, Convert.ToDouble(binary[1].ToString()));
                nn.setInputs(2, Convert.ToDouble(binary[2].ToString()));
                nn.setInputs(3, Convert.ToDouble(binary[3].ToString()));

                nn.run();
                double output = nn.getOuputData(0);
                double act = Convert.ToDouble(actual[n].Text);
                int desired = desired_output[n];
                if (desired == 0)
                {
                    if (output < act)
                    {
                        actual[n].Text = output.ToString("F11");
                        hidden[n].Text = "" + hidden_neurons;
                        epochs[n].Text = "" + epochs_passed;
                    }
                }
                else
                {
                    if (output > act)
                    {
                        actual[n].Text = output.ToString("F11");
                        hidden[n].Text = "" + hidden_neurons;
                        epochs[n].Text = "" + epochs_passed;
                    }
                }
            }
        }

        private void btnTrainMore_Click(object sender, EventArgs e)
        {
            btnTest.Enabled = true;
            btnTestAll.Enabled = true;
            for (int i = 0; i < 1000; i++)
            {
                double cur = Convert.ToDouble(actual[15].Text);
                if (cur >= .9)
                    break;
                train();
                for (int n = 0; n < data; n++)
                {
                    string binary = ConvertToBinary(n, 4);
                    nn.setInputs(0, Convert.ToDouble(binary[0].ToString()));
                    nn.setInputs(1, Convert.ToDouble(binary[1].ToString()));
                    nn.setInputs(2, Convert.ToDouble(binary[2].ToString()));
                    nn.setInputs(3, Convert.ToDouble(binary[3].ToString()));

                    nn.run();
                    double output = nn.getOuputData(0);
                    double act = Convert.ToDouble(actual[n].Text);
                    int desired = desired_output[n];
                    if (desired == 0)
                    {
                        if (output < act)
                        {
                            actual[n].Text = output.ToString("F11");
                            hidden[n].Text = "" + hidden_neurons;
                            epochs[n].Text = "" + epochs_passed;
                        }
                    }
                    else
                    {
                        if (output > act)
                        {
                            actual[n].Text = output.ToString("F11");
                            hidden[n].Text = "" + hidden_neurons;
                            epochs[n].Text = "" + epochs_passed;
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            epochs_passed = 0;
            lblEpochsPassed.Text = "" + epochs_passed;

            textBox1.Enabled = false;
            textBox1.Text = "";
            textBox2.Enabled = false;
            textBox2.Text = "";
            textBox3.Enabled = false;
            textBox3.Text = "";
            textBox4.Enabled = false;
            textBox4.Text = "";

            nn_created = false;
            btnCreate.Enabled = true;

            tbHiddenNeurons.Enabled = true;
            btnSetHiddenNeurons.Enabled = true;
            hidden_neurons = 0;
            lblHiddenNeurons.Text = "" + hidden_neurons;

            tbEpochs.Enabled = false;
            btnSetEpochs.Enabled = false;
            training_iterations = 0;
            lblEpochs.Text = "" + training_iterations;

            btnTrain.Enabled = false;

            btnReset.Enabled = false;

            tbOutput.Text = "";
            btnTest.Enabled = false;
            btnTestAll.Enabled = false;
            btnTrainMore.Enabled = false;

            printed = false;
            tbTrainingData.Text = "";

            for (int i = 0; i < data; i++)
            {
                actual[i].Text = "0";
                hidden[i].Text = "0";
                epochs[i].Text = "0";
            }
        }

        private void saveWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nn_created)
                return;

            SaveFileDialog save = saveFileDialog1;
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
                nn.saveWeights(save.FileName);
        }

        private void loadWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nn_created)
                return;

            OpenFileDialog load = openFileDialog1;
            load.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (load.ShowDialog() == DialogResult.OK)
            {
                nn.loadWeights(load.FileName);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
