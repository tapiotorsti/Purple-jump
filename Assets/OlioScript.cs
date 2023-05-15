using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlioScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveSpeed;
    public float jumpForce;
    public float jumpDelay;

    bool isGrounded;
    bool isJumping;
    float jumpTimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            if (isGrounded)
            {
                myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
            }
            else if (isJumping)
            {
                myRigidbody.AddForce(new Vector2(-moveSpeed, 0f));
            }

            Debug.Log("left");
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            if (isGrounded)
            {
                myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
            }
            else if (isJumping)
            {
                myRigidbody.AddForce(new Vector2(moveSpeed, 0f));
            }

            Debug.Log("right");
        }
        else
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true && isGrounded && !isJumping && Time.time > jumpTimer)
        {
            myRigidbody.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
            isJumping = true;
            jumpTimer = Time.time + jumpDelay;
            Debug.Log("up");
        }

        if (isJumping && myRigidbody.velocity.y < 0)
        {
            isJumping = false;
        }
    }
}
