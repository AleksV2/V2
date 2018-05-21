using UnityEngine;
using System.Collections;

public class Riley : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public float speed = 2;
    public float jumpspeed = 5;

    // Update is called once per frame
    void Update()
    {
        // INPUT

        // Getting rigidbody from the game object we are attached to
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        // Number between 1 and -1 based on player pressing left or right
        float horizontal = Input.GetAxis("Horizontal");

        // Boolean(t/f) based on player pressing spacebar
        bool jump = Input.GetButtonDown("Jump");

        // GROUND COLLISION

        // Get collider attached to the object
        Collider2D collider = GetComponent<Collider2D>();

        // Find out if we are colliding with the ground
        LayerMask groundlayer = LayerMask.GetMask("Ground");

        bool touchingGround = collider.IsTouchingLayers(groundlayer);

        // INPUT SPEED

        // Cache a local copy of our rigidbody velocity
        Vector2 velocity = rigidbody.velocity;

        // Set the x component of the velocity based on input
        velocity.x = horizontal * speed;

        // Set y component of the velocity based on jump
        if (jump == true && touchingGround == true)
        {
            velocity.y = jumpspeed;

        }

        // Set rigidbody velocity based on local copy
        rigidbody.velocity = velocity;

        Animator myAnimator = GetComponent<Animator>();
        myAnimator.SetFloat("speed", Mathf.Abs(velocity.x));

        GetComponent<SpriteRenderer>();

        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        if (velocity.x < 0) {
            mySpriteRenderer.flipX = true;
            }
        if (velocity.x > 0)
        {
            mySpriteRenderer.flipX = false;
        }

        //Print a log when a mouse button is pressed
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse button down");
        }

        //Print a log of the mouse position
        Vector2 mousePosition = Input.mousePosition;
        Debug.Log("mouse position is" + mousePosition);



    }
}
