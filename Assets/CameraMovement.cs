using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.1f;

    public Vector3 offset;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothPosition;

       
    }
}
