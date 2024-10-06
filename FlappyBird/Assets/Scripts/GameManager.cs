using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int highScore = 0;
    public int score = 0;
    public bool isDead = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddPoints()
    {
        score++;
        if (score >= highScore)
        {
            highScore = score;
        }
    }

    public void Death()
    {
        score = 0;
        isDead = true;
    }
}
