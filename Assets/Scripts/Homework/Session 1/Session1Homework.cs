﻿using RC3Students;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {
    // 1. Variables 

    //Declaring: Scope (visibility)  -- Type -- Name -- Value (optional)

    // Numbers
    public int myFirstWholeNumber = 2;
    public int mySecondWholeNumber = 98;

    public float myFisrstDecimaNumber = 1.0f;

    public double myFirstLongDecimaNumber = 1.11111111111111111111111f;

    // Text
    public string mySecondWords = "Hello Gheorghiu, thanks for teaching us!";

    // Logical (binary can be either true or false)
    public bool mySecondBoolean = true;

    // 2. Data Structures
    //Declaring Data Structures: Scope (visibility)  -- Type -- Name -- Value (optional)

    // Arrays
    public int[] myWholeNumberesCollection = new int[5];
    public float[] myDecimalNumberCollection = { 1.0f, 2.0f, 3.0f };

    // Lists
    public List<int> myFirstIntList = new List<int>();

    // 3. Functions
    //Declaring Functions: Scope (visibility)  -- Type -- Variables -- Body (Instructions)
    private float CalculatorSum(float _FisrtNumber, float _SecondNumver)
    {
        float SumResult = _FisrtNumber + _SecondNumver;
        return SumResult;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Update is called once per frame
        float SumResult = CalculatorSum(myFirstWholeNumber, mySecondWholeNumber);
        Debug.Log("Adding two numbers result is:" + SumResult.ToString());

        //Date in Arrays
        //Changing the data
        myDecimalNumberCollection[0] = 3.5f;
        //Retriving the data
        float SumResult2 = CalculatorSum(myDecimalNumberCollection[0], myDecimalNumberCollection[2]);

        //Data in Lists
        //Changing the data
        myFirstIntList.Add(3);
        myFirstIntList.Add(9);
        myFirstIntList[0] = 15;
        myFirstIntList[1] = 22;
        //Retriving the data
        Debug.Log(myFirstIntList[0]);

        //Initialize a Dictionary
        //Create a new dictionary of strings, with string keys.
        Dictionary<string, Student> dict = new Dictionary<string, Student>();

        Student stu1 = new Student("001", "Zhou", "Jielun", 15, "3年二班");
        Student stu2 = new Student("002", "Wang", "Laoji", 15, "3年二班");
        Student stu3 = new Student("003", "Li", "Xiaolong", 15, "3年二班");
        Student stu4 = new Student("004", "Zhao", "Liying", 15, "3年二班");

        //Add to the Dictionary
        dict.Add("Z", stu1);
        dict.Add("W", stu2);
        Student stu = dict["Z"];
        //Remove from the Dictionary
        dict.Remove("W");

        Debug.Log(stu.LastName);

    }
}
