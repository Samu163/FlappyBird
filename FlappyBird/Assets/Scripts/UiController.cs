using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI score;



    public void Update()
    {
        highScore.text = GameManager.instance.highScore.ToString();   
        score.text = GameManager.instance.score.ToString();   
    }
}
