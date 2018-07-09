using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour {

    
    public float viewDistance = 10; // How far they can see
    public float fieldOfView = 60; // View angle (Field of View)

    // Components
    private Transform tf;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    public bool CanSee(GameObject player)
    {
        // If they do not have a collider, they are invisible
        Collider2D targetCollider = player.GetComponent<Collider2D>();
        if (targetCollider == null)
        {
            return false;
        }

        // outside the view angle cannot see 
        Transform targetTransform = player.GetComponent<Transform>();
        Vector3 vectorToTarget = targetTransform.position - tf.position;

        float angle = Vector3.Angle(vectorToTarget, tf.right);
        Debug.Log(" See Targer + angle");

        if (Vector3.Angle(vectorToTarget, tf.right) >= fieldOfView)
        {
            return false;
        }


        //in our field-of-view  
        //raycast 
        RaycastHit2D hitInfo = Physics2D.Raycast(tf.position, vectorToTarget, viewDistance);

        // if our raycast hit nothing, we can't see them
        if (hitInfo.collider == null)
        {
            return false;
        }

        // If our raycast hit them first, then we can see them
        if (hitInfo.collider == targetCollider)
        {
            return true;
        }

        // otherwise, if we hit something else we failed to see them
        return false;
    }
}
