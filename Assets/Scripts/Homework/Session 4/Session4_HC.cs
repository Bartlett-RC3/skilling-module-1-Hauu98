using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_HC : MonoBehaviour
{
    //Variables
    public GameObject columnPrefab;
    bool IsLoading;
    IEnumerator createPrefabsCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        createPrefabsCoroutine = DropPrefabs();
        IsLoading = true;
        // Calling (using) a corutine
        StartCoroutine(createPrefabsCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        //1. Time to stop
        //Debug.Log(Time.time);
        //if (Time.time > 3)
        //{
        //    // Stop a specific coroutine
        //    StopCoroutine(createPrefabsCoroutine);
        //    // Stop all coroutines
        //    StopAllCoroutines();
        //}

        // 2. Press A to stop
        if (Input.GetKeyDown(KeyCode.A))
        {
            IsLoading = false;
        }

    }

    // Coroutines
    IEnumerator DropPrefabs()
    {
        while (IsLoading == true) 
        {
            // Action the corotine (create and drop column)
            Vector3 dropPosition = new Vector3(Random.Range(-5.0f, 12.0f), Random.Range(3.0f, 14.0f), Random.Range(-8.0f, 6.0f));
            Quaternion dropRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            Instantiate(columnPrefab, dropPosition, dropRotation);
            Debug.Log("Loading!");
            yield return new WaitForSeconds(0.1f);
           
        }
        Debug.Log("Finish!");
    }
}
