using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force;
    public Rigidbody2D rb;
    public Vector2 movevector;
    private Animator anim;
    public SpriteRenderer sr;
    public bool OnGround = true;
    public Transform GroundCheck;
    public Vector2 CheckRadius;
    public LayerMask Ground;
    public float jpmod = 2f;
    public float angle = 0f;
    static public bool IsSpaceVisible;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        CheckGround();
        Jumps();
        anim.SetFloat("Air", rb.velocity.y);
    }

    void Jumps()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround && IsSpaceVisible)
            rb.velocity = new Vector2(rb.velocity.x, force);
        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0)
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / jpmod);
    }

    void CheckGround()
    {
        OnGround = Physics2D.OverlapCapsule (GroundCheck.position, CheckRadius, CapsuleDirection2D.Horizontal, angle, Ground);
    }
}
