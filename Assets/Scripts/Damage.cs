using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damageValue;
    public bool isMouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if (isMouse)
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/Mouse2");
            }
            collision.GetComponent<Health>().TakeDamage(damageValue);
        }
            
       
           

    }
}
