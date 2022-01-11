using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle : MonoBehaviour
{
    public int beetleValue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/PointsCollect");
            ScoreManager.instance.ChangeScore(beetleValue);
        }
            
    }
}
