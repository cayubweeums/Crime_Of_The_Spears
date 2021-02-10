using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb2d;
    private Vector3 velocity; 

    // Start is called before the first frame update
    void Start()
    {


        rb2d = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector3.zero;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
        if(velocity != Vector3.zero)
        {
            MoveCharacter();
        }
    }


    void MoveCharacter()
    {
        rb2d.MovePosition(
            transform.position + velocity * speed * Time.deltaTime);
    }


}
