using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class difficultyManager : MonoBehaviour
{
    public float difficulty = 0.01f;
    public static difficultyManager instance;
    public void StartGame()
    {
        DontDestroyOnLoad(this);
        instance = this;
        SceneManager.LoadScene(1);
    }

    public void Easy()
    {
        difficulty = 0.01f;
    }

    public void Normal()
    {
        difficulty = 0.1f;
    }

    public void Hard()
    {
        difficulty = 1f;
    }
}
