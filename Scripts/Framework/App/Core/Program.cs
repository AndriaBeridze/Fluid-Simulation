namespace Fluid.App;

using Fluid.API;
using Raylib_cs;

public static class Program {
    public static void Main(string[] args) {
        Raylib.SetTraceLogLevel(TraceLogLevel.None);
        Raylib.InitWindow(Theme.ScreenWidth, Theme.ScreenHeight, "Fluid Simulation by Andria Beridze");
        Raylib.SetTargetFPS(60);

        App app = new App();

        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Theme.BackgroundColor);

            app.Render();
            app.Update();

            Raylib.EndDrawing();
        }
    }
}