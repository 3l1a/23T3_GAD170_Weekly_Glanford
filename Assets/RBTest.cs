using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBTest : MonoBehaviour
{
    public float JumpForce = 10f;
    public float Speed = 10f;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody RB = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        //if (Input.GetKey(KeyCode.D))
        //{
        //    RB.AddForce(Vector3.right * Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    RB.AddForce(Vector3.left * Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    RB.AddForce(Vector3.forward * Speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    RB.AddForce(Vector3.back * Speed * Time.deltaTime);
        //}

        RB.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Speed * Time.deltaTime );

   
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    
}
}
