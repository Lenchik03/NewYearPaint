using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Cryptography;



NewYearPaint newYearPaint = new NewYearPaint();

ChirstmasTree chirstmasTree = new ChirstmasTree();
chirstmasTree.Point = new Point(100, 100);
newYearPaint.AddPaintObject(chirstmasTree);

Tangerine tangerine = new Tangerine();
tangerine.Point = new Point(120, 170);
newYearPaint.AddPaintObject(tangerine);

NewYearGift newYearGift = new NewYearGift();
newYearGift.Point = new Point(250, 165);
newYearPaint.AddPaintObject(newYearGift);

Snowman snowman = new Snowman();
snowman.Point = new Point(300, 50);
newYearPaint.AddPaintObject(snowman);

ChirstmasToy chirstmasToy = new ChirstmasToy();
chirstmasToy.Point = new Point(70, 60);
newYearPaint.AddPaintObject(chirstmasToy);

newYearPaint.Create();

Console.ReadLine();

public class NewYearPaint
{
    List<ISmallPaint> paints = new List<ISmallPaint>();
    Graphics graphics;
    public NewYearPaint()
    {
        graphics = Graphics.FromHwndInternal(Process.GetCurrentProcess().MainWindowHandle);
    }

    public void Create()
    {
        foreach(var paint in paints)
        {
            paint.Paint(graphics);
        }
        
    }

    public void AddPaintObject(ISmallPaint paint)
    {
        paints.Add(paint);
    }

}

public interface ISmallPaint
{
    void Paint(Graphics graphics);
    public Point Point { get; set; }
}

public class ChirstmasTree : ISmallPaint
{
    public Point Point { get ; set; }

    public void Paint(Graphics graphics)
    {
        graphics.DrawPolygon(Pens.Green, new Point[]
        {
            new Point(Point.X, Point.Y),
            new Point(Point.X - 30, Point.Y - 30),
            new Point(Point.X - 60, Point.Y)
        });

        graphics.DrawPolygon(Pens.Green, new Point[]
        {
            new Point(Point.X - 30, Point.Y),
            new Point(Point.X - 70, Point.Y +20),
            new Point(Point.X +10, Point.Y + 20)
        });

        graphics.DrawPolygon(Pens.Green, new Point[]
        {
            new Point(Point.X - 30, Point.Y + 20),
            new Point(Point.X - 80, Point.Y +50),
            new Point(Point.X + 20, Point.Y + 50)
        });

        graphics.DrawRectangle(Pens.Brown, Point.X - 40, Point.Y + 50, 20, 30);

        graphics.DrawEllipse(Pens.Aqua, Point.X - 35, Point.Y - 20, 5, 5);
        graphics.DrawEllipse(Pens.Pink, Point.X - 45, Point.Y - 10, 5, 5);
        graphics.DrawEllipse(Pens.Yellow, Point.X - 20, Point.Y - 10, 5, 5);
        graphics.DrawEllipse(Pens.Coral, Point.X - 35, Point.Y - 10, 5, 5);
        graphics.DrawEllipse(Pens.Aqua, Point.X - 35, Point.Y + 5, 5, 5);
        graphics.DrawEllipse(Pens.Pink, Point.X - 45, Point.Y + 10, 5, 5);
        graphics.DrawEllipse(Pens.Yellow, Point.X - 20, Point.Y +10, 5, 5);

        graphics.DrawEllipse(Pens.Aqua, Point.X - 35, Point.Y + 25, 5, 5);
        graphics.DrawEllipse(Pens.Pink, Point.X - 60, Point.Y + 40, 5, 5);
        graphics.DrawEllipse(Pens.Yellow, Point.X - 10, Point.Y + 40, 5, 5);
        graphics.DrawEllipse(Pens.Coral, Point.X - 45, Point.Y + 35, 5, 5);
        graphics.DrawEllipse(Pens.Pink, Point.X - 30, Point.Y + 40, 5, 5);
    }
}

public class Tangerine : ISmallPaint
{
    public Point Point { get ; set ; }

    public void Paint(Graphics graphics)
    {
        graphics.FillEllipse(Brushes.Orange, Point.X, Point.Y, 15, 15);
        graphics.FillEllipse(Brushes.Brown, Point.X + 5, Point.Y + 2, 4, 4);

    }
}

public class NewYearGift : ISmallPaint
{
    public Point Point { get ; set; }

    public void Paint(Graphics graphics)
    {
        graphics.FillRectangle(Brushes.White, Point.X, Point.Y, 30, 30);

        graphics.FillRectangle(Brushes.Red, Point.X + 10, Point.Y, 10, 30);

        graphics.DrawCurve(Pens.Red, new Point[]
        {
            new Point(Point.X + 15, Point.Y),
            new Point(Point.X + 20, Point.Y - 5),
            new Point(Point.X + 20, Point.Y - 10),
            new Point(Point.X + 15, Point.Y)
        });

        graphics.DrawCurve(Pens.Red, new Point[]
        {
            new Point(Point.X + 15, Point.Y),
            new Point(Point.X + 10, Point.Y - 5),
            new Point(Point.X + 10, Point.Y - 10),
            new Point(Point.X + 15, Point.Y)
        });
    }
}

public class Snowman : ISmallPaint
{
    public Point Point { get; set; }

    public void Paint(Graphics graphics)
    {
        graphics.FillEllipse(Brushes.White, Point.X, Point.Y, 35, 35);
        graphics.FillEllipse(Brushes.White, Point.X - 8, Point.Y + 30, 50, 50);
        graphics.FillEllipse(Brushes.White, Point.X - 17, Point.Y + 65, 70, 70);

        graphics.FillRectangle(Brushes.Brown, Point.X + 4, Point.Y - 20, 28, 25);

        graphics.FillEllipse(Brushes.Black, Point.X + 6, Point.Y + 10, 5, 5);
        graphics.FillEllipse(Brushes.Black, Point.X + 20, Point.Y + 10, 5, 5);

        graphics.FillPolygon(Brushes.Orange, new Point[]
        {
            new Point(Point.X + 13, Point.Y + 17),
            new Point(Point.X -5, Point.Y + 20),
            new Point(Point.X + 10, Point.Y + 23)
        });

        graphics.FillClosedCurve(Brushes.Black, new Point[] {
                new Point(Point.X + 10, Point.Y + 25),
                new Point(Point.X + 15, Point.Y + 30),
                new Point(Point.X + 20, Point.Y + 25)
            });

        graphics.FillEllipse(Brushes.Orange, Point.X + 35, Point.Y + 40, 15, 15);
        graphics.FillEllipse(Brushes.Orange, Point.X - 15, Point.Y + 40, 15, 15);
        graphics.FillEllipse(Brushes.Orange, Point.X - 15, Point.Y + 120, 20, 20);
        graphics.FillEllipse(Brushes.Orange, Point.X + 30, Point.Y + 120, 20, 20);

    }
}

public class ChirstmasToy : ISmallPaint
{
    public Point Point { get; set; }

    public void Paint(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.Aqua, new Point[]
        {
            new Point(Point.X, Point.Y-5),
            new Point(Point.X + 5, Point.Y + 5),
            new Point(Point.X + 15, Point.Y + 5),
            new Point(Point.X + 6, Point.Y + 10),
            new Point(Point.X + 10, Point.Y + 17),
            new Point(Point.X, Point.Y + 12),

            new Point(Point.X - 10, Point.Y + 17),
            new Point(Point.X - 6, Point.Y + 10),
            new Point(Point.X - 15, Point.Y + 5),
            new Point(Point.X - 5, Point.Y + 5),

        });
    }
}