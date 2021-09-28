using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inheritance
public class animalMovement : obstacleMovement
{

    int direction;

    //polymorphism
    private void Start()
    {
        speed = spawnManager.gameSpeed;
        if (Random.Range(0f, 1f) > 0.5)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!movement.gameOver)
        {
            Strafe();
            transform.Translate(0.2f * speed * direction, 0, -0.1f * speed);
        }
    }

    //abstraction
    void Strafe()
    {
        if (transform.position.x > 13)
        {
            direction = -1;
        }
        if (transform.position.x < -13)
        {
            direction = 1;
        }
    }
}
