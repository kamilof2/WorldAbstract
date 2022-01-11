using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed;
    public int StartingPoint;
    public Transform[] points;
    private int i;




    void Start()
    {
        transform.position = points[StartingPoint].position;
       
    }


    void FixedUpdate()
    {
    if(Vector2.Distance(transform.position, points[i].position)<0.02f)
        {
            i++;
            if (i==points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

    }



    

}

