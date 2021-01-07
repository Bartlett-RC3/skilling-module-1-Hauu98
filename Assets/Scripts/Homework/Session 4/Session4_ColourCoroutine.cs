using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_ColourCoroutine : MonoBehaviour
{
    //Variables
    public GameObject cube;
    public int numberOfCubes = 10;
    public float spaceing = 3.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    bool change;

    // Start is called before the first frame update
    void Start()
    {
        change = true;
        //Create and array of cubes spaced apart
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spaceing, 1, 1);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            cubeCopy.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
            cubeCopies.Add(cubeCopy);
        }
        StartCoroutine (changeColor());
    }
    IEnumerator changeColor()
    {
        while (change == true)
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color Color = new Color(Random.Range(-5.0f, 12.0f), Random.Range(3.0f, 14.0f), Random.Range(-8.0f, 6.0f));
                cubeCopy.GetComponent<MeshRenderer>().material.color = Color;
            }
            yield return null;
        }
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 200, 40), "Click Here to Stop"))
        {
            change = false;
        }
    }
}
