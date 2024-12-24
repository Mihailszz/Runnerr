using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : MonoBehaviour
{
    public bool isGrounded;
    public LayerMask groundLayer;
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public float speed;
    public float increase;
    public ParticleSystem pr;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 20f;
        

    }
    public void Update()
    {
        increase +=  Time.deltaTime/10;
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.92f, transform.position.y - 1.265f),
            new Vector2(transform.position.x + 0.92f, transform.position.y - 1.275f), groundLayer);

            var x_auto = (Time.deltaTime * speed) + increase/100;
            transform.Translate(x_auto, 0, 0);    


            //if (Input.GetMouseButtonDown(0) && isGrounded) {         
       // }
        if (isGrounded == true)
        {
            Strt();
        }
        if (isGrounded == false)
        {
            Stp();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    public void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Strt()
    {
        pr.Play();
    }
    void Stp()
    {
        pr.Pause();
    }
}
