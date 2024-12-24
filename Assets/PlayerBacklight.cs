using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBacklight : MonoBehaviour
{
    public int hearts = 3;
    public int maxhearts = 3;

    public GameObject Player;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] HeartSystem hs;
    private bool CtrlActive;
    private bool isDead;
    private bool isTrig;
    public Animator theAnimator;

    public Collider2D playerCol;
    public GameObject[] childObjs;
    
    public SpriteOpener GameOverScript;

    void FixedUpdate()
    {
        if (hearts>0)
        {
            scoreManager.Score();
            
        }
        if(hearts<=0)
        {
            PlayerDeath();

            FindObjectOfType<GameManager>().EndGame();


        }
            
    }

    private void Start()
    {
        
        hs.DrawHeart(hearts, maxhearts);
        if (hearts > 0)

        { CtrlActive = true; }

        else
        { CtrlActive = false; }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            damagePlayer(1);
        }
        if (collision.tag == "Heart")
        {
            healPlayer(1);
        }
        if (collision.tag == "Shuriken")
        {
            damagePlayer(1);
        }
    }

    void damagePlayer(int dmg)
    {
        if (hearts > 0)
        {
            hearts -= dmg;
            hs.DrawHeart(hearts, maxhearts);
        }
    }

    void healPlayer(int dmg)
    {
        if (hearts < maxhearts)
        {
            hearts += dmg;
            hs.DrawHeart(hearts, maxhearts);
        }
    }
    void PlayerDeath()
    {
        isDead = true;
        theAnimator.SetBool("Dead", isDead);
        
    }
  
}
