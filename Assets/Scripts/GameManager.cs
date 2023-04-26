using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    public void Addlives(int value)
    {
        lives += value;
        if (lives < 0)
        {
            Debug.Log("GameOver!");
            lives = 0;
        }
        Debug.Log("Lives=" + lives);
    }
    public void Addscore(int value)
    {
        score += value;
        Debug.Log("Score=" + score);
    }
}
