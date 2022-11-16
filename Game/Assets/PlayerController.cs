using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 400;
    public float jumpForce = 10;
    public Animator thisani;
    private Collider2D coll;
    public LayerMask groundLayer;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        thisani = gameObject.GetComponent<Animator>();
        coll = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        SwitchAnimation();

    }
    private void Update()
    {
        Jump();

    }


    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");

        if (facedirection != 0)
        {
            rb.velocity = new Vector2(facedirection * speed * Time.deltaTime, rb.velocity.y);
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
        if (horizontalmove != 0)
        {
            thisani.SetFloat("Run", Mathf.Abs(facedirection));

        }

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce);
            thisani.SetBool("Jump", true);
        }
    }

    void SwitchAnimation()
    {
        thisani.SetBool("Idle", false);
        if (thisani.GetBool("Jump"))
        {
            if (rb.velocity.y < 0)
            {
                thisani.SetBool("Jump", false);
                thisani.SetBool("Fall", true);
            }
        }
        else if (isGround())
        {
            thisani.SetBool("Fall", false);
            thisani.SetBool("Idle", true);
        }
    }

    bool isGround()
    {
        if (coll.IsTouchingLayers(groundLayer))
        {
            return true;
        }
        return false;
    }

}
