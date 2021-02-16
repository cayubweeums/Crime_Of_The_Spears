using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float horizontal;
    private float vertical;
    private float moveLimiter = 0.7f;
    public float runSpeed = 0.1f;
    private Animator anim;
 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
            
        }
        rb2d.velocity = new Vector3(horizontal * runSpeed, vertical * runSpeed);

        // Set respective animation for the current movement
        if(horizontal != 0 || vertical != 0)
        {
            anim.SetFloat("moveX", horizontal * runSpeed);
            anim.SetFloat("moveY", vertical * runSpeed);
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }
}
