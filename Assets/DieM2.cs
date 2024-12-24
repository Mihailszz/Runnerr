using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieM2 : MonoBehaviour
{
    public Animator theAnimator;
    private bool isDead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            PlayerDeath();
            Destroy(this.gameObject);
        }
        void PlayerDeath()
        {
            isDead = true;
            theAnimator.SetBool("Dead", isDead);

        }

    }

}
