namespace StarPolygon;

public class StraightLine {
    public static PointF LineIntersection(PointF P1, PointF P2, PointF P3, PointF P4) {
        static float slope(PointF p1, PointF p2) => (p2.Y - p1.Y) / (p2.X - p1.X);

        float slope1 = slope(P1, P2);
        float slope2 = slope(P3, P4);

        PointF intersection = new() {
            X = (P3.Y - P1.Y + slope1 * P1.X - slope2 * P3.X) / (slope1 - slope2)
        };
        
        intersection.Y = P1.Y + slope1 * (intersection.X - P1.X);

        return intersection;
    }
}