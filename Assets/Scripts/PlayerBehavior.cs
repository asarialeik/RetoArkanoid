using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    float xAxisMovement;
    float speed = 1.5f;
    Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xAxisMovement = Input.GetAxis("Horizontal");
        movement = new Vector3(xAxisMovement, 0f, 0f);
        gameObject.transform.Translate(movement * speed * Time.deltaTime);
    }
}
