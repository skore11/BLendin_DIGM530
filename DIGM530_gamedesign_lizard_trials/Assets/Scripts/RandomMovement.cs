using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMovement : MonoBehaviour
{

   
    public float minSpeed;  // minimum range of speed to move
    public float maxSpeed;  // maximum range of speed to move
    float speed;     // speed is a constantly changing value from the random range of minSpeed and maxSpeed 
    //public float height = 1.0f;

  
    public float step = Mathf.PI / 60;
    public float timeVar = 0;
    public float rotationRange = 120;                  //  How far should the object rotate to find a new direction?
    public float baseDirection = 0;

    Vector3 randomDirection;                // Random, constantly changing direction from a narrow range for natural motion

    
    void Update()
    {

        //randomDirection = new Vector3(0, height*(Mathf.Sin(timeVar) * (rotationRange / 2) + baseDirection), 0);
        randomDirection = new Vector3(0, (Mathf.Sin(timeVar) * (rotationRange / 2) + baseDirection), 0); //   Moving at random angles 
        timeVar += step;
        speed = Random.Range(minSpeed, maxSpeed);              //      Change this range of numbers to change speed
        
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        transform.Rotate(randomDirection * Time.deltaTime*2.0f);
        transform.Translate(randomDirection/10 * Time.deltaTime);
    }
}