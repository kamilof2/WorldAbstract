using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollect : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] float healthValue;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            FMODUnity.RuntimeManager.PlayOneShot("event:/HealthCollect");
            health.AddHealth(healthValue);
        }
            
        
    }
}
