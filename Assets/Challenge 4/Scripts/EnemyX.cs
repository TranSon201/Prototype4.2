﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public static float speedEnemy;
    private Rigidbody enemyRb;
    public GameObject playerGoal;
    // Start is called before the first frame update
    void Start()
    {
        speedEnemy = 30.0f;
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (new Vector3(0 , 0, - 31) - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speedEnemy * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
