using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && dino.dinoIsAlive == true)
        {
            logic.addScore();
        }
    }
}
