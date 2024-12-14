using System.Numerics;

namespace Simulator.API;

class ParticleData {
    public int Radius;
    public Vector2 Position;
    public Vector2 Velocity;

    public ParticleData(int radius, Vector2 position, Vector2 velocity) {
        Radius = radius;
        Position = position;
        Velocity = velocity;
    }

    public void Update() {
        Velocity += Settings.Gravity;
        Position += Velocity;

        CheckCollision();
    }

    private int Sign(float value) {
        return value > 0 ? 1 : -1;
    }

    private void CheckCollision() {
        Vector2 position = new Vector2(Position.X - Theme.ScreenWidth / 2, Position.Y - Theme.ScreenHeight / 2);
        Vector2 halfBoundingSize = new Vector2(Theme.BoundingBoxWidth / 2, Theme.BoundingBoxHeight / 2);

        int signX = Sign(position.X);
        int signY = Sign(position.Y);

        // Reflect the particle if it hits the bounding box
        if (Math.Abs(position.X) + Radius + Theme.BoundingBoxThickness > halfBoundingSize.X) {
            Velocity.X *= -1.0f * Settings.DampingFactor;
            Position.X = signX * (halfBoundingSize.X - Radius - Theme.BoundingBoxThickness) + Theme.ScreenWidth / 2;
        }
        if (Math.Abs(position.Y) + Radius + Theme.BoundingBoxThickness > halfBoundingSize.Y) {
            Velocity.Y *= -1.0f * Settings.DampingFactor;
            Position.Y = signY * (halfBoundingSize.Y - Radius - Theme.BoundingBoxThickness) + Theme.ScreenHeight / 2;
        }
    }
}