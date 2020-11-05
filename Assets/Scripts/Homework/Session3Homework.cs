using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    //Variables
    public GameObject cube;
    public int numberOfCubes = 5;
    public float spaceing = 2.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //Create and array of cubes spaced apart
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spaceing, 1, 1);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            cubeCopy.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
            cubeCopies.Add(cubeCopy);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubeCopies.Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
        }

        //Time since game started


        Debug.Log("Unity counted frames: " + Time.frameCount);

        Debug.Log("Time for Unity to draw a frame: " + Time.deltaTime + "seconds");

        // Moving things in unity space (translating)
        foreach (GameObject cubeCopy in cubeCopies)
        {
            // Translate
            Vector3 moveCopy = new Vector3(0, Random.Range(-1.5f, 1.5f), 0);
            cubeCopy.transform.Translate(moveCopy * Time.deltaTime);

            // Rotate
            Vector3 rotateCopy = new Vector3(0, Random.Range(-90.0f, 90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            // Scale
            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;
        }

        // Input

        // Keyboard Input
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                float scaleAmount = 2.0f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                cubeCopy.transform.localScale = scaleCopy;
            }
        }

        // Mouse Input
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color redColor = new Color(1, 0, 0);
                cubeCopy.GetComponent<MeshRenderer>().material.color = redColor;
            }
        }
    }
}
