using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int highScore = 0;
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {
            score++;
            if(score >= highScore)
            {
                highScore = score;
            }
        }
        else if (Input.GetKeyUp(KeyCode.O))
        {
            score = 0;
        }
    }
}
