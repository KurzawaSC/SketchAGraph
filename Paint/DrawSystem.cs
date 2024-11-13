using MathNet.Symbolics;

namespace SketchAGraph;

public class DrawSystem
{
    public static string? func = null;
    public static double x_min;
    public static double x_max;
    public static double y_max;
    public static double y_min;
    public static bool x_enable = true;
    public static bool y_enable = true;



    public static void DrawAxis(Graphics graphics, int width, int height)
    {
        var blackPen = new Pen(Color.Black, 1);
        if (x_enable == true)
        {
            graphics.DrawLine(blackPen, 0, height / 2, width, height / 2);
            graphics.DrawLine(blackPen, 0, 0, width, 0);
            graphics.DrawLine(blackPen, 0, height - 1, width, height - 1);
            graphics.DrawLine(blackPen, 0, 1 * (height / 4), width, 1 * (height / 4));
            graphics.DrawLine(blackPen, 0, 2 * (height / 4), width, 2 * (height / 4));
            graphics.DrawLine(blackPen, 0, 3 * (height / 4), width, 3 * (height / 4));
        }
        if (y_enable == true)
        {
            graphics.DrawLine(blackPen, width / 2, 0, width / 2, height);
            graphics.DrawLine(blackPen, 0, 0, 0, height);
            graphics.DrawLine(blackPen, height - 1, 0, height - 1, height);
            graphics.DrawLine(blackPen, 1 * (width / 4), 0, 1 * (width / 4), height);
            graphics.DrawLine(blackPen, 2 * (width / 4), 0, 2 * (width / 4), height);
            graphics.DrawLine(blackPen, 3 * (width / 4), 0, 3 * (width / 4), height);
        }
    }

    public static double EvalY(double x)
    {
        var eq = SymbolicExpression.Parse(func);

        var values = new Dictionary<string, FloatingPoint> { { "x", x } };

        double y = eq.Evaluate(values).RealValue;

        return y;
    }

    public static Point[] GetPoints(int width, int height)
    {
        var yPoints = new List<double>();
        var Points = new List<Point>();
        double xScale = width / (x_max - x_min);

        for (int i = 0; i < width; i++)
        {
            double tmpX = x_min + i / xScale;
            yPoints.Add(EvalY(tmpX));
        }

        var yMin = yPoints.Min();
        var yMax = yPoints.Max();
        double yRange = (yMax - yMin)*1.1;

        double yScale = height / yRange;

        double yCenter = height - ((-yMin) * yScale);

        for (int i = 0; i < width; i++)
        {
            double tmpX = x_min + i / xScale;
            double tmpY = yCenter - EvalY(tmpX) * yScale;

            Points.Add(new Point(i, Math.Clamp((int)tmpY, 0, height - 1)));
        }

        y_max = yMax;
        y_min = yMin;
        return Points.ToArray();
    }


    public static void DrawFunc(PictureBox pb)
    {
        int width = pb.Width;
        int height = pb.Height;


        Bitmap bmp = new Bitmap(width, height);
        using (Graphics graphics = Graphics.FromImage(bmp))
        {
            graphics.Clear(Color.White);

            DrawAxis(graphics, width, height);
            if (func is not null && x_max > x_min)
            {
                var points = GetPoints(width, height);
                var bluePen = new Pen(Color.Blue, 2);

                graphics.DrawCurve(bluePen, points);
            }
            else if (func is null)
            {

            }
            else if (func == "")
            {
                MessageBox.Show("Musisz podać funkcję");
            }
            else if (x_min > x_max)
            {
                MessageBox.Show("Lewy przedział musi być mniejszy od prawego");
            }
        }

        pb.Image = bmp;
    }
}
