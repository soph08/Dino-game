using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMoveScript : MonoBehaviour
{
    public float cactusSpeed = 5;
    public float deadzone = -25;
    public LogicScript logic;
    public BoxCollider2D myBoxCollider;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * cactusSpeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }    
    }

    
}
