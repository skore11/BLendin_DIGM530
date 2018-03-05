using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMovement : MonoBehaviour
{

   
    public float minSpeed;  // minimum range of speed to move
    public float maxSpeed;  // maximum range of speed to move
    float speed;     // speed is a constantly changing value from the random range of minSpeed and maxSpeed 

  
    float step = Mathf.PI / 60;
    float timeVar = 0;
    float rotationRange = 120;                  //  How far should the object rotate to find a new direction?
    float baseDirection = 0;

    Vector3 randomDirection;                // Random, constantly changing direction from a narrow range for natural motion

    /*
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == collisionTags[0])
        {                   //  Tag it with a wall or other object
            GetComponent<AudioSource>().PlayOneShot(collisionSound, 2.0f);         //  Plays a sound on collision
            baseDirection = baseDirection + Random.Range(-30, 30);   // Switch to a new direction on collision

            // use the above code as a template for all the collisionTags
            // add here.. and on.. and on..
        }

     
    }


    /* void OnCollisionEnter(Collision collision)              //  Another collision example {
        baseDirection = baseDirection + Random.Range(-30.0f, 30.0f);
        if (collision.gameObject.name == "Refined Controller")        //  Collides with player
        {
            Application.LoadLevel("Title");               //  Reload the level if the player is hit
        }
    } */
    void Update()
    {

        randomDirection = new Vector3(0, Mathf.Sin(timeVar) * (rotationRange / 2) + baseDirection, 0); //   Moving at random angles 
        timeVar += step;
        speed = Random.Range(minSpeed, maxSpeed);              //      Change this range of numbers to change speed
        //GetComponent<Rigidbody>().AddForce(transform.up * speed);
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        transform.Rotate(randomDirection * Time.deltaTime*2.0f);
        transform.Translate(randomDirection/10 * Time.deltaTime);
    }
}