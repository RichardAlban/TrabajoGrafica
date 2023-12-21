namespace PaneldeAbeja;

class BeePanel {
    public readonly int Columns = 5;
    public readonly List<List<Hexagon>> Panels = new();

    private int ComputeColumns(int currentColumn) {
        return -Math.Abs(currentColumn - Columns / 2) + Columns;
    }

    public BeePanel(float hexagonSide) {
        for (int i = 0; i < Columns; ++i) {
            Panels.Add(new List<Hexagon>());

            for (int j = 0; j < ComputeColumns(i); ++j) {
                PointF hexagonCenter = new() {
                    X = ((i + 1) * hexagonSide) + (i * hexagonSide / 2),
                    Y = (2 * j + Math.Abs(i - Columns / 2) + 1) * Hexagon.ComputeApothem(hexagonSide)
                };

                Panels[i].Add(new Hexagon(hexagonCenter, hexagonSide));
            }
        }
    }

    public void Plot(PictureBox canvas, Color outline, Color fill) {
        foreach (var columnPanel in Panels) {
            foreach (var panel in columnPanel) {
                panel.Plot(canvas, outline, fill);
            }
        }
    }
}