﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth); 
        if (currentHealth > 0)
        {

        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
    public void AddHealth(float healthToAdd)
    {
        currentHealth += healthToAdd;
    }
    
}
