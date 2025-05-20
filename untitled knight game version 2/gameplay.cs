using Godot;
using System;

public partial class gameplay : Node2D
{
	
	public double dblTimer = 0;
	public int intAction = 0;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// what happens when spacebar is pressed
	if (Input.IsActionPressed("action")){
		intAction = 5;
	}
	
	// what happens when w or up key is pressed
	if (Input.IsActionPressed("up")){
		intAction = 8;
	}
	
	// what happens when down or s key is pressed
	if (Input.IsActionPressed("down")){
		intAction = 2;
	}
	
	// what happens when a or left key is pressed
	if (Input.IsActionPressed("left")){
		intAction = 4;
	}
	
	// what happens when d or right key is pressed
	if (Input.IsActionPressed("right")){
		intAction = 6;
	}
	
	// what happens when a or left and up or w keys are pressed
	if (Input.IsActionPressed("left") & Input.IsActionPressed("up")){
		intAction = 7;
	}
	
	// what happens when d or right and up and w keys are pressed
	if (Input.IsActionPressed("right") & Input.IsActionPressed("up")){
		intAction = 9;
	}
	
	// what happens when left or a and down or s keys are pressed
	if (Input.IsActionPressed("left") & Input.IsActionPressed("down")){
		intAction = 1;
	}
	
	// what happens when right or d and down or s keys are pressed
	if (Input.IsActionPressed("right") & Input.IsActionPressed("down")){
		intAction = 3;
	}
	}
	
	public void _on_timer_timeout()
	{
	dblTimer = dblTimer + 0.25;
	
	// what happens when game overs at this second
	if (dblTimer == 1.5){
		if (intAction != 2){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 3){
		if (intAction != 8){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 5){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 6){
		if (intAction != 8){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 7.50){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 9){
		if (intAction != 2){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 11.25){
		if (intAction != 6){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 12){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 14){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 16){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 18){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 20){
		if (intAction != 6){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 22){
		if (intAction != 2){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 23){
		if (intAction != 2){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 25){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 27){
		if (intAction != 6){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 28){
		if (intAction != 6){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 30){
		if (intAction != 3){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	
	// what happens when game overs at this second
	if (dblTimer == 31){
		if (intAction != 5){
			// sends player back to beginning
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
	}
	}

	// game does not go back to the start like its supposed to due to engine glitches
	// sends player back to main menu at end of game
	public void _on_video_stream_player_finished()
	{
		// sends player back to beginning
		GetTree().ChangeSceneToFile("res://MainMenu.tscn");
	}
}
