# Repository Instructions

This project is a 2D game similar to Flappy Bird.

When suggesting or completing Unity physics code for `Rigidbody2D`, do not use `velocity` because it is deprecated in this project context. Prefer `linearVelocity` instead.

Example:

```csharp
myRigidbody.linearVelocity = Vector2.up * flapStrength;
```