namespace BeePanel;

class BeePanel {
    public readonly int Columns = 5;
    public readonly List<Hexagon> Panels = new();

    private int ComputeRows(int currentColumn) {
        return -Math.Abs(currentColumn - Columns / 2) + Columns;
    }

    public BeePanel(float hexagonSide) {
        for (int j = 0; j < Columns; ++j) {
            for (int i = 0; i < ComputeRows(j); ++i) {
                PointF hexagonCenter = new() {
                    X = ((j + 1) * hexagonSide) + (j * hexagonSide / 2),
                    Y = (2 * i + Math.Abs(j - Columns / 2) + 1) * Hexagon.ComputeApothem(hexagonSide)
                };

                Panels.Add(new Hexagon(hexagonCenter, hexagonSide));
            }
        }
    }

    public void Plot(PictureBox canvas, Color outline, Color fill) {
        foreach (var panel in Panels) {
            panel.Plot(canvas, outline, fill);
        }
    }
}