using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFall : MonoBehaviour
{
    // variables 
    public Rigidbody2D rbEnemy;
    public float fallSpeed = 5f;
    public float lifeTime = 5f;

    private void Start()
    {

        Destroy(gameObject, lifeTime);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //rbEnemy.AddForce(new Vector2(moveSpeed, 0));

        rbEnemy.velocity = new Vector2(0, -fallSpeed);


    }




}
