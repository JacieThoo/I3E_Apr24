using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
