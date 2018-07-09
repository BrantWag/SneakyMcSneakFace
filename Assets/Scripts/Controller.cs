using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Abstract Controller class - no implementation - only classes that derive from it have logic
public abstract class Controller : MonoBehaviour
{
	public Vector3 homePosition;
	public Pawn pawn;

	public virtual void Start()
	{
		pawn = GetComponent<Pawn>();
	}
}
