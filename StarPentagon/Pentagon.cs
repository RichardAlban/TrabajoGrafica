namespace StarPolygon;

public class Pentagon {
    public const int Sides = 5;
    public const float CenterAngle = 72;
    public const float InternalAngle = 54;
    public readonly float Side;
    public readonly float Radius;
    public readonly float InclinationAngle;
    public readonly PointF Center;
    public readonly PointF[] Vertices = new PointF[Sides];
    
    public Pentagon(float side, PointF center, float inclinationAngle = 0) {
        Side = side;
        Center = center;
        InclinationAngle = inclinationAngle;
        Radius = Side * (float) Math.Sin(Angle.ConvertDegreeToRadians(InternalAngle)) / (float) Math.Sin(Angle.ConvertDegreeToRadians(CenterAngle));

        for (int i = 0; i < Sides; ++i) {
            Vertices[i].X = Center.X + Radius * (float) Math.Cos(Angle.ConvertDegreeToRadians(InclinationAngle + i * CenterAngle)) * StarPolygon.ScalarFactor;
            Vertices[i].Y = Center.Y + -Radius * (float) Math.Sin(Angle.ConvertDegreeToRadians(InclinationAngle + i * CenterAngle)) * StarPolygon.ScalarFactor;
        }
    }

    public static float ComputeSide(float radius) {
        return radius * (float)Math.Sin(Angle.ConvertDegreeToRadians(CenterAngle)) / (float)Math.Sin(Angle.ConvertDegreeToRadians(InternalAngle));
    }

    public PointF[] ComputeMedians() {
        PointF[] medians = new PointF[Sides];

        for (int i = 0; i < Sides; ++i) {
            medians[i] = new PointF {
                X = (Vertices[i].X + Vertices[(Sides + i + 1) % Sides].X) / 2,
                Y = (Vertices[i].Y + Vertices[(Sides + i + 1) % Sides].Y) / 2,
            };
        }

        return medians;
    }

    public PointF[] ComputeMedianIntersections() {
        PointF[] medians = ComputeMedians();
        PointF[] intersections = new PointF[Sides];

        for (int i = 0; i < Sides; ++i) {
            intersections[i] = StraightLine.LineIntersection(Vertices[i], medians[(Sides + i + 1) % Sides], Vertices[(Sides + i + 1) % Sides], medians[(Sides + i + 4) % Sides]);
        }

        return intersections;
    }

    public void Plot(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        var shape = Vertices;
        _ = shape.Append(shape[0]);

        illustrator.DrawPolygon(pen, shape);
    }

    public void PlotInternalStar(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        PointF[] star = new PointF[Sides + 1];

        for (int i = 0, j = 0; i < star.Length; ++i, j += 2)
            star[i] = Vertices[(Sides + j) % Sides];

        illustrator.DrawPolygon(pen, star);
    }
}