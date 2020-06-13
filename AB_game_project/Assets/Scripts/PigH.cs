using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigH : MonoBehaviour
{

    float health = 5f;
    Rigidbody2D rb;
  
    void Start () {
        rb = GetComponent <Rigidbody2D> ();
    }
    void Update ( ) {

        // Debug.Log (health);
        if (health <= 0) {
            Destroy (this.gameObject);

        }
    }
    void OnCollisionEnter2D (Collision2D col) {
        if (col.relativeVelocity.magnitude > 0.1) {
           // Debug.Log (col.relativeVelocity.magnitude);
            health -= col.relativeVelocity.magnitude;
            }

            if (rb.velocity.magnitude > 1) {
             health -=    rb.velocity.magnitude * 0.5f;
            }
            
            
            
       
    }
}
