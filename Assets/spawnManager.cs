using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //public static bool gameOver;
    public GameObject obstaclePrefab;
    public GameObject animalPrefab;
    public static float gameSpeed
    {
        get { return m_gameSpeed; }
        set { m_gameSpeed = value; }
    }
    static float m_gameSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //gameOver = false;
        InvokeRepeating("spawnEnemy",1.5f,1.5f);
        gameSpeed = difficultyManager.instance.difficulty;
    }

    void spawnEnemy()
{
        if (!movement.gameOver)
        {
            if (Random.Range(0f, 1f) > 0.5)
            {
                Instantiate(obstaclePrefab, new Vector3(Random.Range(-13, 13), 0, 5), transform.rotation);
            }
            else
            {
                Instantiate(animalPrefab, new Vector3(Random.Range(-13, 13), 0, 5), transform.rotation);
            }
                gameSpeed += 0.01f;
        }
}
}