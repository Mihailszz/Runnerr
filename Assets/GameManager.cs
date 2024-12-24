using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject GameOverSprite;
    public GameObject button1;
    public GameObject button2;
    public GameObject lightup1;
    public GameObject lightup2;
    public GameObject replay;

    public GameObject score1;
    public GameObject scori;
    public GameObject highscore;
    public GameObject name1;
    public GameObject name2;
    public GameObject home;


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            OpenClose();
        }
        
    }

    public void OpenClose()
    {

        bool iActive = GameOverSprite.activeSelf;
        GameOverSprite.SetActive(!iActive);

        if (button1 != null)
        {
            bool Shuriken = button1.activeSelf;
            button1.SetActive(!Shuriken);
        }

        if (button2 != null)
        {
            bool jump = button2.activeSelf;
            button2.SetActive(!jump);
        }
        if (lightup1 != null)
        {
            bool a = lightup1.activeSelf;
            lightup1.SetActive(!a);
        }
        if (lightup1 != null)
        {
            bool b = lightup2.activeSelf;
            lightup2.SetActive(!b);
        }
        if (replay != null)
        {
            bool c = replay.activeSelf;
            replay.SetActive(!c);
        }
        if (score1 != null)
        {
            bool d = score1.activeSelf;
            score1.SetActive(!d);
        }
        if (scori != null)
        {
            bool e = scori.activeSelf;
           scori.SetActive(!e);
        }
        if (highscore != null)
        {
            bool f = highscore.activeSelf;
           highscore.SetActive(!f);
        }
        if (name1 != null)
        {
            bool g = name1.activeSelf;
            name1.SetActive(!g);
        }
        if (name2 != null)
        {
            bool h = name2.activeSelf;
           name2.SetActive(!h);
        }
        if (home != null)
        {
            bool i = home.activeSelf;
            home.SetActive(!i);
        }


    }
}
