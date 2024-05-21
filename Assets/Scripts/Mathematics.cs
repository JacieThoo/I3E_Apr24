using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathematics : MonoBehaviour
{

    int a = 5;
    int x = 10;
    int y = 20;



    void QuickMath()
    {
        if (a < x)
        {
            int sum = a + y;
            if (sum < x)
            {
                Debug.Log("x is the biggest number");
            }
            else
            {
                Debug.Log("x is not the biggest number");
            }
        }
        else
        {
            int remainder = a % y;
            Debug.Log(remainder);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        QuickMath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
