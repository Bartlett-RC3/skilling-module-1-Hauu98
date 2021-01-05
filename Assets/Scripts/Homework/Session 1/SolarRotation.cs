using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class
public class SolarRotation : MonoBehaviour
{
    // Variables
    public float rotationSpeedSelf = 20.0f;
    public float rotationSpeedSun = 50.0f;
    public GameObject sun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation around the planet axis
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, rotationSpeedSelf * Time.deltaTime);

        // Rotation around the sun
        this.gameObject.transform.RotateAround(sun.transform.position, Vector3.up, rotationSpeedSun * Time.deltaTime);
    }
}