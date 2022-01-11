using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float maxHealth = 100f;
    float health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddDamage(float damageValue)
    {
         health = Mathf.Clamp((health - damageValue),0f, 100f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Beetle"))
        {
            Destroy(other.gameObject);
        }

    }
}
