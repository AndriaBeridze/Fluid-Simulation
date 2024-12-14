namespace Fluid.App;

using System.Numerics;
using Fluid.API;
using Raylib_cs;

public class App {
    Particle particle;

    public App() {
        particle = new Particle(new ParticleData(10, new Vector2(500, 500), new Vector2(0, 0)));
    }

    public void Update() {
        particle.Update();
    }

    public void Render() {
        Vector2 topLeft = new Vector2(Theme.ScreenWidth / 2, Theme.ScreenHeight / 2) - new Vector2(Theme.BoundingBoxWidth / 2, Theme.BoundingBoxHeight / 2);
        Raylib.DrawRectangleLinesEx(new Rectangle(topLeft.X, topLeft.Y, Theme.BoundingBoxWidth, Theme.BoundingBoxHeight), Theme.BoundingBoxThickness, Theme.BoundingBoxColor);
    
        particle.Render();
    }
}