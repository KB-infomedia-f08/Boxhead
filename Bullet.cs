using Godot;
using System;

public partial class Bullet : Area2D
{
	public Vector2 velocity;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		var mPosition = Position;
		mPosition += velocity*(float)delta;
		Position = mPosition;
	}
}
