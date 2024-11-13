using SketchAGraph;

namespace Paint
{
    public partial class SketchAGraphForm : Form
    {
        public SketchAGraphForm()
        {
            InitializeComponent();
            DrawSystem.DrawFunc(pictureBox1);
        }

        private void sketchAGraphButton_Click(object sender, EventArgs e)
        {
            DrawSystem.func = textBoxFunction.Text;
            labelAbovePB.Text = "Wykres funkcji:\n" + textBoxFunction.Text;
            if (!double.TryParse(textBox1.Text, out DrawSystem.x_min)
                || !double.TryParse(textBox2.Text, out DrawSystem.x_max))
            {
                MessageBox.Show("Musisz okreœliæ przedzia³");
                return;
            }
            DrawSystem.DrawFunc(pictureBox1);
            MarkLabels();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DrawSystem.x_enable = true;
                x1Label.Visible = true;
                x2Label.Visible = true;
                x3Label.Visible = true;
                x4Label.Visible = true;
                x5Label.Visible = true;
            }
            else
            {
                DrawSystem.x_enable = false;
                x1Label.Visible = false;
                x2Label.Visible = false;
                x3Label.Visible = false;
                x4Label.Visible = false;
                x5Label.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                DrawSystem.y_enable = true;
                y1Label.Visible = true;
                y2Label.Visible = true;
                y3Label.Visible = true;
                y4Label.Visible = true;
                y5Label.Visible = true;
            }
            else
            {
                DrawSystem.y_enable = false;
                y1Label.Visible = false;
                y2Label.Visible = false;
                y3Label.Visible = false;
                y4Label.Visible = false;
                y5Label.Visible = false;
            }
        }

        private void yAxisLabel_Paint(object sender, PaintEventArgs e)
        {
            var brush = new SolidBrush(Color.Black);
            var font = new Font("Segoe UI", 9);
            e.Graphics.TranslateTransform(yAxisLabel.Width / 2, yAxisLabel.Height / 2);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Oœ Y", font, brush, 0, 0);
        }

        private void MarkLabels()
        {
            double x1 = DrawSystem.x_min;
            double x2 = DrawSystem.x_max;

            x1Label.Text = x1.ToString();
            x2Label.Text = (x1 + (x2 - x1) / 4).ToString();
            x3Label.Text = (x1 + (x2 - x1) / 2).ToString();
            x4Label.Text = (x1 + 3 * ((x2 - x1) / 4)).ToString();
            x5Label.Text = x2.ToString();

            var y1 = DrawSystem.y_max;
            var y2 = DrawSystem.y_min;

            y1Label.Text = Math.Round(y2,1).ToString();
            y2Label.Text = Math.Round(((y1 - y2) / 4),1).ToString();
            y3Label.Text = Math.Round((2*(y1 - y2) / 4),1).ToString();
            y4Label.Text = Math.Round((3*(y1 - y2) / 3),1).ToString();
            y5Label.Text = Math.Round(y1,1).ToString();
        }
    }
}
