using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hearts=3;
    public int maxhearts=3;
    [SerializeField] HeartSystem hs;
    
    private void Start()
    {
        hs.DrawHeart(hearts, maxhearts);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster" )
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
}
