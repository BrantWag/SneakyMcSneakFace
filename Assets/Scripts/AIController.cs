using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Inherit from Controller
public class AIController : Controller {

	float lastMovedTime;

	public float timeToMove;

	// Use this for initialization
	public override void Start()
	{
		base.Start();
		lastMovedTime = Time.time;
	}

	// Update is called once per frame
	void Update () {

		if ((Time.time - lastMovedTime) > timeToMove)
		{
			lastMovedTime = Time.time;

			int movement = Random.Range(0, 4);
			if (movement == 0)
			{
				pawn.MoveForward();
			}
			else if (movement == 1)
			{
				pawn.MoveBackward();
			}
			else if (movement == 2)
			{
				pawn.RotateLeft();
			}
			else if (movement == 3)
			{
				pawn.RotateRight();
			}
		}
	}
}
