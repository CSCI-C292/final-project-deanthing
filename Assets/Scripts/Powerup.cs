using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Player") {
            // increase player speed
            Debug.Log("hit powerup");
            GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 2.5f;
            Destroy(gameObject);
        }
    }
}
