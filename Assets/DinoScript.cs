using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    bool jumped = false;
    public bool dinoIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumped == false && dinoIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
            jumped = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumped = false;
    }
}
