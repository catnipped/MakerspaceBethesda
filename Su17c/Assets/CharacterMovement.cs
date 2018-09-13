using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private SpriteRenderer spriteRend;
    private BoxCollider2D coll;

    public CanWalk rightTrigger;
    public CanWalk leftTrigger;
    public CanWalk bottomTrigger;

    public bool doJump = false;
    public bool isGrounded = true;
    public float xInput = 0f;

    public float movementSpeed = 200f;
    public float jumpSpeed = 1000f;

    // Use this for initialization
    void Start()
    {
        //Hämtar komponenter.
        rbody2D = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        CheckGrounded();
        //Om man vill hoppa, hoppa.
        Jump();

        //Flytta karaktären

        if (xInput > 0)
        {
            if (!rightTrigger.IsTouching())
            {
                rbody2D.velocity = new Vector2(xInput *
                    movementSpeed, rbody2D.velocity.y);
            }
        }
        else if (xInput < 0)
        {
            if (!leftTrigger.IsTouching())
            {
                rbody2D.velocity = new Vector2(xInput *
                    movementSpeed, rbody2D.velocity.y);
            }
        }
        else if (xInput == 0)
        {
            rbody2D.velocity = new Vector2(0, rbody2D.velocity.y);
        }


        FaceMovingDirection();
    }

    private void FaceMovingDirection()
    {
        //Vänd gubben åt hållet man går.
        if (xInput < 0)
            spriteRend.flipX = true;
        else if (xInput > 0)
            spriteRend.flipX = false;
    }

    private void CheckGrounded()
    {
        if (bottomTrigger.IsTouching())
        {
            isGrounded = true;
        }
    }

    private void Jump()
    {
        if (doJump)
        {
            isGrounded = false;
            rbody2D.velocity = new Vector2(rbody2D.velocity.x, jumpSpeed);

            //Glöm inte att återställa hoppet.
            doJump = false;
        }
    }
}
