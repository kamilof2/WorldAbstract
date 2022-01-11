using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeThrow : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    private float coolDownTimer;
    // Start is called before the first frame update
    void Attack()
    {
        coolDownTimer = 0;
        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<EnemyProjectile>().ActivateProjectile();
    }

    private int FindFireball()
    {
        for (int i=0; i<fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        coolDownTimer += Time.deltaTime;
        if (coolDownTimer >= attackCooldown)
            Attack();
    }
}
