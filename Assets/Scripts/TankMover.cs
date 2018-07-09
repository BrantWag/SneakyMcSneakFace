using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{

	private Transform tf;
    public Vector2 playerStartPosition;
    public float speed;
	public float turnSpeed; 


	void Start () {
		tf = GetComponent<Transform>();
        transform.position = playerStartPosition;

    }

	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			tf.Translate(Vector3.right * 0.05f); //up
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			tf.Translate (Vector3.left * 0.05f); //down
        }
		if (Input.GetKey (KeyCode.LeftArrow)) {
			tf.Rotate (0, 0, turnSpeed); //rotate left
        }
		if (Input.GetKey (KeyCode.RightArrow )){
			tf.Rotate (0, 0, -turnSpeed); //rotate right 
        }
		//if (Input.GetKey (KeyCode.Space))
			//tf.position = Vector3.zero;
	}
}
