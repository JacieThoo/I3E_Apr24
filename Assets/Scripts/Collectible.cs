using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    bool isCollected = false;
    int myValue = 10;
    float expirationTime = 5.5f;
    string myName = " Just A Coin";
    bool canCollect = true;

    void OnCollisionEnter(Collision collision)
    {
        GetCollected();
    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnCollisionStay(Collision collision)
    {

    }

    void GetCollected()
    {
        Debug.Log("I got collected!");
    }

    void Expired()
    {
        Debug.Log("Sorry! I expired!");
    }

    void CollectMe()
    {
        Debug.Log("Quick! Collect me!");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered my area");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Something exited my area");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Something is still in my area");
    }



    // Start is called before the first frame update
    void Start()
    {
        //Calling the GetCollected function
        CollectMe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
