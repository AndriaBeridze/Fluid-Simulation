namespace Fluid.App;

using Fluid.API;
using Raylib_cs;

class Particle {
    private ParticleData data;

    public Particle(ParticleData data) {
        this.data = data;
    }

    public void Update() {
        data.Update();
    }

    public void Render() {
        Raylib.DrawCircleV(data.Position, data.Radius, Theme.ParticleColor);
    }
}