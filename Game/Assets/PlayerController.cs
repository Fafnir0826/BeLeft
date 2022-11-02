using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 400;
    public float jumpForce = 10;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
    private void Update()
    {
        Jump();
    }

    void Movement() 
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");

        if (horizontalmove != 0) 
        {
            rb.velocity = new Vector2(horizontalmove * speed * Time.deltaTime , rb.velocity.y);
        }
        if (facedirection != 0) 
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
        
    }
    void Jump() 
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(gameObject.transform.position.y<0.1)
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
