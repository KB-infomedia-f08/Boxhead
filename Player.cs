using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	float speed = 250f;

	public override void _Ready(){

	}

	public override void _PhysicsProcess(double delta)
	{
		var direction = Input.GetVector("left", "right", "up", "down");
		Velocity = direction*speed;
		MoveAndSlide();
	}
}
