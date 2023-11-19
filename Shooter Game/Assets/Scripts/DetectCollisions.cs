using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Instead of destroying the projectile when it collides with an obstacle
        //Destroy(other.gameObject); 

        // Just deactivate the bullet and destroy the obstacle
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }

}
