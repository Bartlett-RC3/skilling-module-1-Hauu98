using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Press WASD for RayCast, Create Tower to rebuild the spring wall");
    }
	
	// Update is called once per frame
	void Update () {
        // Move the cube up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up*0.01f);
        }

        // Move the cube down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.01f);
        }
        // Move the cube left
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * 0.01f);
        }
        // Move the cube right
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * 0.01f);
        }
        // First let's get the position from where we are casting the ray
        Vector3 rayCastPosition = transform.position;

        // Then create a ray in the direction we want to cast
        Vector3 rayCastDirection = transform.TransformDirection(Vector3.back);

        // Create a variable that stores the information about what we are hitting
        RaycastHit objectSeenByRay;

        // Cast the ray
        if (Physics.Raycast(rayCastPosition, rayCastDirection, out objectSeenByRay))
        {
            Debug.Log("Object seen: "+ objectSeenByRay.transform.name);
            Debug.Log("Object position: " + objectSeenByRay.transform.ToString());
            Debug.Log("Point where ray is hitting the object:  " + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);
        }
    }
}
