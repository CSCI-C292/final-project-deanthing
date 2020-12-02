using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    void Start() {
        GameObject[] gameObjects =  GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject en in gameObjects) 
            Destroy(en);

    }
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.SimpleMove(move * speed * Time.deltaTime * 40);

    }

}
