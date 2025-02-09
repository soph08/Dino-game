using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public LogicScript logic;
    public DinoScript dino;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        dino = GameObject.FindGameObjectWithTag("Dino").GetComponent<DinoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        logic.gameOver();
        dino.dinoIsAlive = false;
    }
}
