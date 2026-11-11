using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	float speed = 250f;
	Marker2D bulletSpawner;
	[Export]
	PackedScene bulletScene;
	public override void _Ready(){
		bulletSpawner = GetNode<Marker2D>("BulletSpawner");
	}

	public override void _PhysicsProcess(double delta)
	{
		var direction = Input.GetVector("left", "right", "up", "down");
		Velocity = direction*speed;
		MoveAndSlide();
	}

    public override void _Process(double delta)
    {
		if (Input.IsActionJustPressed("shoot"))
		{
			var bullet = bulletScene.Instantiate<Bullet>();
			bullet.GlobalPosition = bulletSpawner.GlobalPosition;
			var direction = bulletSpawner.GlobalPosition - GlobalPosition;
			bullet.velocity = direction.Normalized() * 400;
			bullet.Rotation = direction.Angle();
			Owner.AddChild(bullet);
		}
    }
}
