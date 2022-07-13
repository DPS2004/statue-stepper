using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public bool isGrounded;
    float hMovement = 0;
    public float hSpeed = 100;
    public float jForce = 120;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        checkInput();
    }

    void checkInput()
    {
        hMovement = Input.GetAxisRaw("Horizontal");
        rb.AddForce(hMovement * hSpeed, rb.velocity.y, 0);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * jForce);
        }

        if(Input.GetButtonDown("Switch"))
        {
            this.rb.isKinematic = true;
            GameObject.Find("Statue1").GetComponent<Movement>().enabled = false;
            GameObject.Find("Statue2").GetComponent<Movement1>().enabled = true;
            GameObject.Find("Statue2").GetComponent<Rigidbody>().isKinematic = false;

        }    
    }
}
