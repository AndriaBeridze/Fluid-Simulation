namespace Simulator.App;

using System.Numerics;
using Simulator.API;
using Raylib_cs;

public class App {
    Fluid fluid;

    public App() {
        fluid = new Fluid(1024);
    }

    public void Update() {
        fluid.Update();
    }

    public void Render() {
        Vector2 topLeft = new Vector2(Theme.ScreenWidth / 2, Theme.ScreenHeight / 2) - new Vector2(Theme.BoundingBoxWidth / 2, Theme.BoundingBoxHeight / 2);
        Raylib.DrawRectangleLinesEx(new Rectangle(topLeft.X, topLeft.Y, Theme.BoundingBoxWidth, Theme.BoundingBoxHeight), Theme.BoundingBoxThickness, Theme.BoundingBoxColor);
    
        fluid.Render();
    }
}