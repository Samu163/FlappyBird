using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject deathScene;
    public int highScore = 0;
    public int score = 0;
    public bool isDead = false;
    public AudioSource pointFX;
    public AudioSource deathFX;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        deathScene.SetActive(false);

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

        pointFX.Play();

    }

    public void Death()
    {
        score = 0;
       
        if(!isDead)
        {
           deathFX.Play();
        }
        isDead = true;
        deathScene.SetActive(true);
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
