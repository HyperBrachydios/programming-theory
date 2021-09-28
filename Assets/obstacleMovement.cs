using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    //encapsulation?
    public float m_speed;
    public float speed
    {
        get { return m_speed; }
        set { m_speed = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = spawnManager.gameSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!movement.gameOver)
        {
            transform.Translate(0, 0, -0.1f * speed);
        }
    }
}
