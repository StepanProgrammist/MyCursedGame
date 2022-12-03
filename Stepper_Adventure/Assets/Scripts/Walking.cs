using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 movevector;
    private Animator anim;
    public SpriteRenderer sr;

    static public bool IsRightButtonVisible;
    static public bool IsLeftButtonVisible;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        GoRight();
        GoLeft();
        Flip();
        Stop();
    }
    
    void GoRight()
    {
        movevector.x = Input.GetAxis("Horizontal");
        if (movevector.x > 0 && IsRightButtonVisible)
        {
            rb.velocity = new Vector2(speed * movevector.x, rb.velocity.y);
            anim.SetFloat("Move", Mathf.Abs(movevector.x));
        }
    }
    void GoLeft()
    {
        movevector.x = Input.GetAxis("Horizontal");
        if (movevector.x < 0 && IsLeftButtonVisible)
        {
            rb.velocity = new Vector2(speed * movevector.x, rb.velocity.y);
            anim.SetFloat("Move", Mathf.Abs(movevector.x));
        }
    }
    void Flip()
    {
        sr.flipX = movevector.x < 0f;
    }
    void Stop()
    {
        if (movevector.x == 0)
            rb.velocity = new Vector2(0, rb.velocity.y);
        if (rb.velocity.x <= 0.1f && rb.velocity.x >= -0.1f)
            anim.SetFloat("Move", 0f);
    }
}
