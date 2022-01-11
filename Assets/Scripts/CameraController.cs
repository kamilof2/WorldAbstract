using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    [Range (1,10)]
    public float smoothFactor;
    public Vector3 minValues, maxValue;

    private void FixedUpdate()
    {
        Follow();
    }

    // Update is called once per frame
    void Follow()
    {
        //Define minimum, max, x,y,z
        Vector3 targetPosition = target.position + offset;
        //Verify if targetpoint is out of bound or not
 

        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(targetPosition.x, minValues.x, maxValue.x),
            Mathf.Clamp(targetPosition.y, minValues.y, maxValue.y),
            Mathf.Clamp(targetPosition.z, minValues.z, maxValue.z));




        Vector3 smoothPosition = Vector3.Lerp(transform.position, boundPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
