namespace Paint
{
    partial class SketchAGraphForm
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
            textBoxFunction = new TextBox();
            label1 = new Label();
            sketchAGraphButton = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBox2 = new CheckBox();
            labelAbovePB = new Label();
            xAxisLabel = new Label();
            yAxisLabel = new Label();
            y1Label = new Label();
            y2Label = new Label();
            y3Label = new Label();
            y4Label = new Label();
            y5Label = new Label();
            x1Label = new Label();
            x2Label = new Label();
            x3Label = new Label();
            x4Label = new Label();
            x5Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxFunction
            // 
            textBoxFunction.Location = new Point(32, 76);
            textBoxFunction.Name = "textBoxFunction";
            textBoxFunction.Size = new Size(305, 27);
            textBoxFunction.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Funkcja";
            // 
            // sketchAGraphButton
            // 
            sketchAGraphButton.Location = new Point(128, 262);
            sketchAGraphButton.Name = "sketchAGraphButton";
            sketchAGraphButton.Size = new Size(200, 200);
            sketchAGraphButton.TabIndex = 2;
            sketchAGraphButton.Text = "Sketch a graph";
            sketchAGraphButton.UseVisualStyleBackColor = true;
            sketchAGraphButton.Click += sketchAGraphButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 126);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "X od";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 126);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 5;
            label3.Text = "do";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 27);
            textBox2.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(33, 176);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Oś X";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(500, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(32, 206);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(60, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Oś Y";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // labelAbovePB
            // 
            labelAbovePB.Location = new Point(675, 5);
            labelAbovePB.Name = "labelAbovePB";
            labelAbovePB.Size = new Size(150, 40);
            labelAbovePB.TabIndex = 12;
            labelAbovePB.Text = "Wykres funkcji:";
            labelAbovePB.TextAlign = ContentAlignment.TopCenter;
            // 
            // xAxisLabel
            // 
            xAxisLabel.AutoSize = true;
            xAxisLabel.Location = new Point(675, 553);
            xAxisLabel.Name = "xAxisLabel";
            xAxisLabel.Size = new Size(39, 20);
            xAxisLabel.TabIndex = 13;
            xAxisLabel.Text = "Oś X";
            xAxisLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // yAxisLabel
            // 
            yAxisLabel.Location = new Point(447, 325);
            yAxisLabel.Name = "yAxisLabel";
            yAxisLabel.Size = new Size(47, 88);
            yAxisLabel.TabIndex = 14;
            yAxisLabel.TextAlign = ContentAlignment.TopCenter;
            yAxisLabel.Paint += yAxisLabel_Paint;
            // 
            // y1Label
            // 
            y1Label.AutoSize = true;
            y1Label.Location = new Point(444, 539);
            y1Label.Name = "y1Label";
            y1Label.Size = new Size(0, 20);
            y1Label.TabIndex = 15;
            // 
            // y2Label
            // 
            y2Label.AutoSize = true;
            y2Label.Location = new Point(444, 413);
            y2Label.Name = "y2Label";
            y2Label.Size = new Size(0, 20);
            y2Label.TabIndex = 16;
            // 
            // y3Label
            // 
            y3Label.AutoSize = true;
            y3Label.Location = new Point(444, 287);
            y3Label.Name = "y3Label";
            y3Label.Size = new Size(0, 20);
            y3Label.TabIndex = 17;
            // 
            // y4Label
            // 
            y4Label.AutoSize = true;
            y4Label.Location = new Point(444, 164);
            y4Label.Name = "y4Label";
            y4Label.Size = new Size(0, 20);
            y4Label.TabIndex = 18;
            // 
            // y5Label
            // 
            y5Label.AutoSize = true;
            y5Label.Location = new Point(444, 50);
            y5Label.Name = "y5Label";
            y5Label.Size = new Size(0, 20);
            y5Label.TabIndex = 19;
            // 
            // x1Label
            // 
            x1Label.AutoSize = true;
            x1Label.Location = new Point(500, 553);
            x1Label.Name = "x1Label";
            x1Label.Size = new Size(0, 20);
            x1Label.TabIndex = 20;
            // 
            // x2Label
            // 
            x2Label.AutoSize = true;
            x2Label.Location = new Point(611, 553);
            x2Label.Name = "x2Label";
            x2Label.Size = new Size(0, 20);
            x2Label.TabIndex = 21;
            // 
            // x3Label
            // 
            x3Label.AutoSize = true;
            x3Label.Location = new Point(741, 553);
            x3Label.Name = "x3Label";
            x3Label.Size = new Size(0, 20);
            x3Label.TabIndex = 22;
            // 
            // x4Label
            // 
            x4Label.AutoSize = true;
            x4Label.Location = new Point(866, 553);
            x4Label.Name = "x4Label";
            x4Label.Size = new Size(0, 20);
            x4Label.TabIndex = 23;
            // 
            // x5Label
            // 
            x5Label.AutoSize = true;
            x5Label.Location = new Point(969, 553);
            x5Label.Name = "x5Label";
            x5Label.Size = new Size(0, 20);
            x5Label.TabIndex = 24;
            // 
            // SketchAGraph
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(x5Label);
            Controls.Add(x4Label);
            Controls.Add(x3Label);
            Controls.Add(x2Label);
            Controls.Add(x1Label);
            Controls.Add(y5Label);
            Controls.Add(y4Label);
            Controls.Add(y3Label);
            Controls.Add(y2Label);
            Controls.Add(y1Label);
            Controls.Add(yAxisLabel);
            Controls.Add(xAxisLabel);
            Controls.Add(labelAbovePB);
            Controls.Add(checkBox2);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(sketchAGraphButton);
            Controls.Add(label1);
            Controls.Add(textBoxFunction);
            Name = "SketchAGraph";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFunction;
        private Label label1;
        private Button sketchAGraphButton;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private CheckBox checkBox2;
        private Label labelAbovePB;
        private Label xAxisLabel;
        private Label yAxisLabel;
        private Label y1Label;
        private Label y2Label;
        private Label y3Label;
        private Label y4Label;
        private Label y5Label;
        private Label x1Label;
        private Label x2Label;
        private Label x3Label;
        private Label x4Label;
        private Label x5Label;
    }
}
