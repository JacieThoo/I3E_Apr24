using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private void OnCollisionEnter (Collision collision)
    {
        Debug.Log("A collision has occurred");
    }

    private void OnCollisionExit (Collision collision)
    {
        Debug.Log("A collision has stopped");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("A collision is still occurring");
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
