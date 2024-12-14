namespace Simulator.API;

using System.Numerics;
using Raylib_cs;

class Settings {
    public static float DampingFactor = 0.7f;

    public static int ParticleRadius = 5;
    public static int InitialDistance = 5;

    public static Vector2 Gravity = new Vector2(0, 0);
}