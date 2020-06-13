using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BirdsHelper : MonoBehaviour
{
   public Vector2 StartPosition { get; set; }

    // Use this for initialization
    void Start()
    {
        StartPosition = transform.position;
        
    }


    // Update is called once per frame
     void OnCollisionEnter2D(Collision2D other)
    {
    if (other.gameObject.tag == "Respawn") {
        Invoke( "EnableGO", 3f );
    }
    }
void EnableGO()
 {
  SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
 }
    
}

