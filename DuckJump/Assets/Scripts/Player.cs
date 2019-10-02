using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // variables
    public float jumpForce = 10f;
    public float moveSpeed;
    public float moveAmount = 2f;
    public Vector2 leftPos;
    public Rigidbody2D rb;

    private Vector2 target;

    // Update is called once per frame
    void Update()
    {
        // player movement controls
        // NOTES - make if statement to check if players current positon is left, if player preses e and is in that pos already dont move
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)){
       

            rb.velocity = Vector2.up * jumpForce;
            Debug.Log("Player Jumped");



        }


        if (Input.touchCount > 0)
        {

            Debug.Log("Player touch jump");
            Touch touch = Input.GetTouch(0);
            //Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            //transform.position = touchPos;
            rb.velocity = Vector2.up * jumpForce;

            

        }



    }



    // check for collisions and destroy player object
    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("player collsion");
        Destroy(gameObject);


    }


}
