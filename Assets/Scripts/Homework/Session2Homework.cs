using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DogClass;

public class Session2Homework : MonoBehaviour
{
    //Variables
    Session2Homework_DogClass dog1, dog2, dog3;


    // Start is called before the first frame update
    void Start()
    {
        //1. Write a function that uses a condition
        int test = AddTwoNum(10, 20);
        Debug.Log(test);

        int min = 2;
        int hour = 1;
        int test2 = GetTotalSecond(min, hour);
        Debug.Log(hour + "hour " + "minutes = " + test2 +  "seconds");

        //2. Write a for loop
        for (int i = 0; i<5; i++ )
        {
            Debug.Log("冲！");
        }

        float Cardboard = 0.00001f;
        for (int i = 0; i < 30; i++)
        {
            Cardboard *= 2;
        }
        //While
        //Exercise
        float height = 100f;
        int count = 0;
        float distance = height;
        while (height / 2 >= 0.01f)
        {
            height /= 2;
            count++;
            distance += height * 2;
        }

        //3. Write a dog class and initialize an instance of the class
        dog1 = new Session2Homework_DogClass("小白", 3);
        dog2 = new Session2Homework_DogClass("小黑", 5);
        dog3 = new Session2Homework_DogClass("小花", 1);
    }
    void Update()
    {
        Debug.Log(dog1.GetName());
        dog1.SetClothing();
    }

    //Function
    /// <summary>
    /// Add two int numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private static int AddTwoNum(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Minutes transfer to seconds
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    private static int GetTotalSecond(int minute)
    {
        return minute * 60;
    }
    private static int GetTotalSecond(int minute, int hour)
    {
        return GetTotalSecond(minute + hour * 60);
    }
}

