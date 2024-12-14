namespace Simulator.App;

using Simulator.API;
using System.Numerics;
using System.Security;
using System.Xml.Schema;

class Density {
    public static float CalculateDensity(Vector2 position, float smoothingRadius, List<Particle> particles) {
        float density = 0;

        foreach (Particle particle in particles) {
            float dist = Math.Abs((position - particle.Position).Length());
            density += SmoothingKernel(dist, smoothingRadius);
        }

        return density;
    }

    private static float SmoothingKernel(float dist, float smoothingRadius) {
        float volume = (float) Math.PI * (float) Math.Pow(smoothingRadius, 8) / 4;
        float value = Math.Max(0, smoothingRadius * smoothingRadius - dist * dist) * 31.0f;

        return value * value * value / volume;
    }
}