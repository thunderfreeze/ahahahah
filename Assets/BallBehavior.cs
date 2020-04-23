﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

    public float m_speed = 1000f;
    public Rigidbody2D m_rb2D;
    public float BulletDestroyTimer = 1f;
   





    // Update is called once per frame
    void FixedUpdate()
    {
       


            transform.Translate(Vector3.right * Time.deltaTime * m_speed);
            Destroy(gameObject, BulletDestroyTimer);



        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        
    }

}
