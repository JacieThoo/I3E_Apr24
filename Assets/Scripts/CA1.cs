/*
 * Author: Jacie Thoo Yixuan
 * Date: 4/28/2024
 * Description: This script is for the 3 tasks given in I3E CA1
 */

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CA1 : MonoBehaviour
{
    /// <summary>
    /// A function to check whether 2 numbers are equal, if not print the larger number
    /// </summary>
    void IntCompare()
    {
        int firstNum = 12;
        int secondNum = 7;

        if (firstNum == secondNum) //check if equal
        {
            Debug.Log("The two numbers are are equal");
        }
        else
        {
            if (secondNum > firstNum) //check which one is larger
            {
                Debug.Log("The larger number is " + secondNum);
            }
            else
            {
                Debug.Log("The larger number is " + firstNum);
            }
        }
    }

    /// <summary>
    /// To print numbers 1 to 10 using for loop
    /// </summary>
    void LoopNums()
    {   
        string numString = ""; //string to put numbers in
        for (int i = 1; i <= 10; ++i) //use declaration check. if true, execute operation
        {
            numString += i + ", "; //add to string
        }
        Debug.Log(numString);
    }

    /// <summary>
    /// To print Hello World 10 times using while loop
    /// </summary>
    void PrintHelloWorld()
    {
        int count = 0; //base count starts at 0
        while (count < 10) //as long as count below 10, print Hello World
        {
            Debug.Log("Hello World");
            count++; //increase count
        }
    }

    /// <summary>
    /// To call IntCompare when player presses E on keyboard
    /// </summary>
    void OnActionOne()
    {
        IntCompare();
    }

    /// <summary>
    /// To call LoopNums when user presses L on keyboard
    /// </summary>
    void OnActionTwo()
    {
        LoopNums();
    }

    /// <summary>
    /// To call PrintHelloWorld when user presses V on keyboard
    /// </summary>
    void OnActionThree()
    {
        PrintHelloWorld();
    }

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
