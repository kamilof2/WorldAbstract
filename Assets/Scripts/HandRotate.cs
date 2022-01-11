using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRotate : MonoBehaviour
{
    private float rotationZ;
    [SerializeField] private float speed;
    [SerializeField] float angle;
    public Vector3 anglesToRotate;
    private float minAngle, maxAngle;
    private bool turningRight;
    float currentRotationZ;
    public Vector3 currentRotation;
    float timer = 0f;
    int phase = 0;
    // Update is called once per frame
    private void Awake()
    {
        speed /= 100;
        angle /= 100;
        currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        transform.eulerAngles = currentRotation;
        minAngle = (currentRotation.z- angle)%360f;
        maxAngle = (currentRotation.z + angle)% 360f;
      // Debug.Log(transform.localRotation.eulerAngles.z + " - " + minAngle + " - " + maxAngle);
        turningRight = true;
    }
    void Update()
    {

        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 4;            //Keep the phase between 0 to 3.
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0f, 0f, transform.rotation.z + speed * (1 - timer) * angle);  //Speed, from maximum to zero.
                break;
            case 1:
                transform.Rotate(0f, 0f, transform.rotation.z  -speed * timer * angle);       //Speed, from zero to maximum.
                break;
            case 2:
                transform.Rotate(0f, 0f, transform.rotation.z  -speed * (1 - timer) * angle); //Speed, from maximum to zero.
                break;
            case 3:
                transform.Rotate(0f, 0f, transform.rotation.z + speed * timer * angle);        //Speed, from zero to maximum.
                break;
        }


    }
   

}



/* 
 * 
 * 
 * 
 *   currentRotation += anglesToRotate * Time.deltaTime * rotationSpeed;
        currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        transform.eulerAngles = currentRotation;
 * if (turningRight)
        {
            //Debug.Log("prawo");
            if (transform.localRotation.eulerAngles.z < maxAngle)
            {
                rotationZ += Time.deltaTime * rotationSpeed;
                if (rotationZ <= 0)
                    rotationZ = 360;
                rotationZ =  Mathf.Clamp(rotationZ, 0, 360);
                transform.rotation = Quaternion.Euler(0, 0, rotationZ);
                
            }
            else
                turningRight = false;
        }
        else
        {
            Debug.Log(transform.localRotation.eulerAngles.z);
            if (transform.localRotation.eulerAngles.z > minAngle)
            {
                rotationZ -= Time.deltaTime * rotationSpeed;

                rotationZ = Mathf.Clamp(rotationZ, 0, 360);
                transform.rotation = Quaternion.Euler(0, 0, rotationZ);
            }
            else
                turningRight = true;
        }     
*/
