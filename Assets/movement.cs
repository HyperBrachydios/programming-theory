using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float horizontalInput;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (!gameOver)
        {
            transform.Translate(horizontalInput / 25, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameOver = true;
        Debug.Log("Game over");
    }
}
