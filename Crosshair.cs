using Godot;
using System;

public partial class Crosshair : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var mPosition = GetGlobalMousePosition() - ((CharacterBody2D)GetParent()).GlobalPosition;
		var distance = Math.Min(400, mPosition.Length());
		mPosition = mPosition.Normalized() * distance;
		Position = mPosition;
	}
}
