namespace BeePanel;
public class Hexagon {
    public readonly float a;
    public readonly float b;
    public readonly float Side;
    public readonly PointF Center;
    public const float ScalarFactor = 10;
    public readonly Dictionary<char, PointF> Vertices;
    private Graphics? _illustrator;
    private Pen? _pen;
    private SolidBrush? _brush;

    public static float ComputeApothem(float side) {
        return (float)Math.Sqrt(3) * side / 2.0f;
    }

    public Hexagon(PointF center, float side) {
        Side = side;
        Center = center;

        a = ComputeApothem(Side);
        b = Side / 2.0f;

        Vertices = new Dictionary<char, PointF> {
            { 'A', new PointF((Center.X - b) * ScalarFactor, (Center.Y - a) * ScalarFactor) },
            { 'B', new PointF((Center.X + b) * ScalarFactor, (Center.Y - a) * ScalarFactor) },
            { 'C', new PointF((Center.X + Side) * ScalarFactor, Center.Y * ScalarFactor) },
            { 'D', new PointF((Center.X + b) * ScalarFactor, (Center.Y + a) * ScalarFactor) },
            { 'E', new PointF((Center.X - b) * ScalarFactor, (Center.Y + a) * ScalarFactor) },
            { 'F', new PointF((Center.X - Side) * ScalarFactor, Center.Y * ScalarFactor) }
        };
    }

    public void Plot(PictureBox canvas, Color outline, Color fill) {
        _illustrator = canvas.CreateGraphics();
        _pen = new Pen(outline);
        _brush = new SolidBrush(fill);

        PointF[] vertices = Vertices.Values.ToArray();
        _ = vertices.Append(vertices[0]);

        _illustrator.FillPolygon(_brush, vertices);
        _illustrator.DrawPolygon(_pen, vertices);
    }
}