using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour
{
    int myScore = 7;

    void Collected()
    {
        Debug.Log(gameObject.name + " got collided with"); 
        Destroy(gameObject); // destroy after colliding
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //check if it has the player tag (make it so only player can collide into it)
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore); 
            Collected(); //call collected
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
