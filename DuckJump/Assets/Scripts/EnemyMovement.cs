using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // variables 
    public Rigidbody2D rbEnemy;
    public float moveSpeed = 5f;
    public float lifeTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, lifeTime);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //rbEnemy.AddForce(new Vector2(moveSpeed, 0));

        rbEnemy.velocity = new Vector2(moveSpeed, 0);


    }

    


}
