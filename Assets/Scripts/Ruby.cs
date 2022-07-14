using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    // Start is called before the first frame update
    float rotspeed = -0.75F;
    float siner = 0f;
    float sinscale = 0.1f;
    float basey;
    void Start()
    {
        basey = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        siner = (siner + Time.deltaTime) % (Mathf.PI * 2);
        transform.position = new Vector3(transform.position.x,basey + Mathf.Sin(siner) * sinscale,transform.position.z);
        transform.Rotate(0, rotspeed * Time.deltaTime * 60, 0, Space.World);
    }

}
