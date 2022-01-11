using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesiaGate : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    private BoxCollider2D boxCollider;
    private CapsuleCollider2D SphereCollider;
    
    // Start is called before the first frame update
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        SphereCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (scoreManager.score == 11)
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/OpenGate");
                SphereCollider.enabled = false;
                boxCollider.enabled = false;
            }
            else
                FMODUnity.RuntimeManager.PlayOneShot("event:/Robaczki");
  
        }

    }
}
