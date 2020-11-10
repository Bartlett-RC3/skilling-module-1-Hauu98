using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_RayCasting_20: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.up * 0.1f);

        }
        //Move object down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * 0.1f);

        }

        // Check if an object is setting another object using Ray Casting
        //First let;s get the position from where we are casting
        Vector3 rayCastPosition = this.gameObject.transform.position;

        // Then create a ray in the direction we want to cast
        Vector3 rayCastDirection = this.gameObject.transform.TransformDirection(Vector3.back);

        // Create a variable that stores the information about what we are hitting 
        RaycastHit objectSeenByRay;

        // Cast the ray
        if (Physics.Raycast(rayCastPosition, rayCastDirection, out objectSeenByRay)) ;
        {
            Debug.Log("Object seen: "+ objectSeenByRay.transform.name);
            Debug.Log("Object position: " + objectSeenByRay.transform.ToString());
            Debug.Log("Point where ray is hitting the object" + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);
        }
    }
}
