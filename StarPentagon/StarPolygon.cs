namespace StarPolygon;

public class StarPolygon {
    public const float ScalarFactor = 20;
    private readonly PointF Origin;
    private readonly Pentagon RightTiltedPentagon;
    private readonly Pentagon LeftTiltedPentagon;
    private readonly Pentagon CenteredPentagon;
    private readonly Pentagon StarPentagon;
    private readonly PointF[] MediansCenteredPentagon;
    private readonly PointF[] MedianIntersectionsCenteredPentagon;

    private Pentagon ComputeCenteredPentagon() {
        float radiusCenteredPentagon = Math.Abs(StraightLine.LineIntersection(RightTiltedPentagon.Vertices[0], RightTiltedPentagon.Vertices[1], LeftTiltedPentagon.Vertices[0], LeftTiltedPentagon.Vertices[1]).Y - Origin.Y) / ScalarFactor;

        float sideCenteredPentagon = Pentagon.ComputeSide(radiusCenteredPentagon);

        const float parallelToOrdinateAxis = 18;
        return new(sideCenteredPentagon, Origin, parallelToOrdinateAxis);
    }

    private Pentagon ComputeStarPentagon() {
        const float parallelToOrdinateAxis = 18;
        
        float radiusOfStar = Math.Abs(MedianIntersectionsCenteredPentagon[0].X - Origin.X) / ScalarFactor;

        float sidePentagonStar = Pentagon.ComputeSide(radiusOfStar);

        float heightFromOriginAtFirstPentagonVertex = radiusOfStar * (float)Math.Sin(parallelToOrdinateAxis);

        PointF originStar = new() {
            X = Origin.X,
            Y = Origin.Y - heightFromOriginAtFirstPentagonVertex
        };

        return new(sidePentagonStar, originStar, parallelToOrdinateAxis);
    }

    private void ConnectPentagonsVertices(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        for (int i = 0; i < Pentagon.Sides; ++i) {
            illustrator.DrawLine(pen, RightTiltedPentagon.Vertices[i], CenteredPentagon.Vertices[(Pentagon.Sides + i - 1) % Pentagon.Sides]);
            illustrator.DrawLine(pen, LeftTiltedPentagon.Vertices[i], CenteredPentagon.Vertices[(Pentagon.Sides + i + 1) % Pentagon.Sides]);
        }
    }
    
    private void DrawMedians(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        for (int i = 0; i < Pentagon.Sides; ++i) {
            illustrator.DrawLine(pen, CenteredPentagon.Vertices[i], MediansCenteredPentagon[(Pentagon.Sides + i + 1) % Pentagon.Sides]);
            illustrator.DrawLine(pen, CenteredPentagon.Vertices[i], MediansCenteredPentagon[(Pentagon.Sides + i - 2) % Pentagon.Sides]);
        }
    }

    private void ConnectMediansAndVertices(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        for (int i = 0; i < Pentagon.Sides; ++i) {
            illustrator.DrawLine(pen, MediansCenteredPentagon[i], StarPentagon.Vertices[i]);
            illustrator.DrawLine(pen, MediansCenteredPentagon[i], StarPentagon.Vertices[(Pentagon.Sides + i + 1) % Pentagon.Sides]);
        }
    }

    private void ConnectMedianIntersectionsAndPoints(PictureBox canvas) {
        Graphics illustrator = canvas.CreateGraphics();
        Pen pen = new(Color.Black);

        for (int i = 0; i < Pentagon.Sides; ++i) {
            illustrator.DrawLine(pen, MedianIntersectionsCenteredPentagon[i], StarPentagon.Vertices[i]);
            illustrator.DrawLine(pen, MedianIntersectionsCenteredPentagon[i], StarPentagon.Vertices[(Pentagon.Sides + i + 1) % Pentagon.Sides]);
        }
    }

    public StarPolygon(float pentagonSide, PointF origin) {
        const float leftHandOrientation = 36;

        Origin = origin;
        RightTiltedPentagon = new(pentagonSide, Origin);
        LeftTiltedPentagon = new(pentagonSide, Origin, leftHandOrientation);
        CenteredPentagon = ComputeCenteredPentagon();
        MediansCenteredPentagon = CenteredPentagon.ComputeMedians();
        MedianIntersectionsCenteredPentagon = CenteredPentagon.ComputeMedianIntersections();
        StarPentagon = ComputeStarPentagon();
    }

    public void Plot(PictureBox pictureBoxCanvas) {
        RightTiltedPentagon.Plot(pictureBoxCanvas);
        LeftTiltedPentagon.Plot(pictureBoxCanvas);
        CenteredPentagon.Plot(pictureBoxCanvas);
        ConnectPentagonsVertices(pictureBoxCanvas);
        DrawMedians(pictureBoxCanvas);
        StarPentagon.PlotInternalStar(pictureBoxCanvas);
        ConnectMediansAndVertices(pictureBoxCanvas);
        ConnectMedianIntersectionsAndPoints(pictureBoxCanvas);
    }
}