using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 20f;
    public float JumpSpeed = 5f;

    private float JumpMovement; 
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");


        Vector2 walkMovement = new Vector2(horizontalMovement, 0);


        rigidbody.AddForce(walkMovement * Speed);




        if (JumpMovement > 0f)
        {
            rigidbody.velocity = new Vector2(JumpMovement * Speed, rigidbody.velocity.y);
        }
        else if(JumpMovement < 0f)
        {
            rigidbody.velocity = new Vector2(JumpMovement * Speed, rigidbody.velocity.y);
        }
        else
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);



        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, JumpSpeed);


        }
    }
}
