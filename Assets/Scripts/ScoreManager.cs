using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    /*
    public Transform Player;
    public Text scoreText;

    void Update()
    {
        scoreText=Player.position.x.ToString("0");
    }
    */
    public Text ScoreText;
    public float score;
    

    public Transform Player;

    private void Update()
    {
        if(score>PlayerPrefs.GetInt("highestscore"))
        PlayerPrefs.SetInt("highestscore", (int)score/1000);
    }

    public void Score()
    {
        if (GameObject.FindGameObjectsWithTag("Player")!=null)
        {
            //score += 3 * Time.deltaTime;
            
            score += Player.position.x;
            ScoreText.text = ((int)score/1000).ToString();

           
        }
    }
    
}

