using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingPlatform : MonoBehaviour
{
    public float delay;
    Collision2D collision2d;

    public float force = 1f;
    // Start is called before the firstframe update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.AddForce(new Vector2(0f,force));
            Destroy(gameObject, 0.1f);
        }
            
    }
   
}
