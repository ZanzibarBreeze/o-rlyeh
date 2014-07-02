﻿using UnityEngine;
using System.Collections;

// ATTACH TO GAME CONTROLLER
// updates the player stats and controls the general flow of the game

public class ProgressTracker : MonoBehaviour {

	// PLAYER STATS - these are updated in THIS (ProgressTracker) script 
	public int ap;		// action points - max 5 (regenerate if sleep, -- if talk or action)
	public int like;	// liking level - 0 to 10 
	public int susp; 	// suspicion level - 0 to 4

	// TO UPDATE THE STATS WITHIN THE DIALOGUE TRACKER
	public DialogueTracker dtrack; 

	// GAME FLOW STUFF
	public int day;		// 0 to 4 = 5 days total 


	void Start () 
	{
		
	}

	void Update () 
	{

		
	}

	/* --------------------------------------------------------------------------------------------------------------------------
	 * NO ARGS. NO RETURN. 
	 * updates the player stat values (ap, like, susp) in the dialogue tracker to match the ones in progress tracker
	 * -------------------------------------------------------------------------------------------------------------------------- */

	private void updateDStats()
	{
		dtrack.ap = ap;
		dtrack.like = like;
		dtrack.susp = susp; 
	}
}