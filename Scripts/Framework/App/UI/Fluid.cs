namespace Simulator.App;

using System.Numerics;
using Simulator.API;
using Raylib_cs;

class Fluid {
    List<Particle> particles;

    public Fluid(int numParticles) {
        int root = (int) Math.Sqrt(numParticles);
        particles = new List<Particle>();

        for (int i = 0; i < numParticles; i++) {
            int x = i % root;
            int y = i / root;
            
            int offset = Settings.InitialDistance + Settings.ParticleRadius * 2;
            Vector2 position = new Vector2(Theme.ScreenWidth / 2 + (x - root / 2) * offset, Theme.ScreenHeight / 2 + (y - root / 2) * offset);
            particles.Add(new Particle(new ParticleData(Settings.ParticleRadius, position, new Vector2(0, 0))));
        }
    }

    public void Update() {
        foreach (Particle particle in particles) {
            particle.Update();
        }
    }

    public void Render() {
        foreach (Particle particle in particles) {
            particle.Render();
        }

        Vector2 center = new Vector2(Theme.ScreenWidth / 2, Theme.ScreenHeight / 2);
    }
}