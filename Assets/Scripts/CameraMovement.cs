using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Ramon;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = Ramon.transform.position.x;
        transform.position = position;
    }


    //4 directions
    /*public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        follow();
    }

    void follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }*/
}
