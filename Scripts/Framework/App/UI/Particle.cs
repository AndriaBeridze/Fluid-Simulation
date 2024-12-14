namespace Simulator.App;

using Simulator.API;
using Raylib_cs;
using System.Numerics;

class Particle {
    private ParticleData data;

    public Particle(ParticleData data) {
        this.data = data;
    }

    public Vector2 Position => data.Position;
    public Vector2 Velocity => data.Velocity;
    public float Radius => data.Radius;

    public void Update() {
        data.Update();
    }

    public void Render() {
        Raylib.DrawCircleV(data.Position, data.Radius, Theme.ParticleColor);
    }
}