using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_2020 : MonoBehaviour
{
    //Variables
    public GameObject columnPrefab;
    IEnumerator createPrefabsCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        createPrefabsCoroutine = DropPrefabs();
        // Calling (using) a corutine
        StartCoroutine(createPrefabsCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(Time.time);
        if (Time.time > 3)
        {
            // Stop a specific coroutine
            StopCoroutine(createPrefabsCoroutine);
            // Stop all coroutines
            StopAllCoroutines();
        }

    }

    // Coroutines
    IEnumerator DropPrefabs()
    {
        while (true) 
        {
            // Action the corotine (create and drop column)
            Vector3 dropPosition = new Vector3(Random.Range(-5.0f, 12.0f), Random.Range(3.0f, 14.0f), Random.Range(-8.0f, 6.0f));
            Quaternion dropRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            Instantiate(columnPrefab, dropPosition, dropRotation);
            yield return new WaitForSeconds(0.1f);

        }
    }
}
