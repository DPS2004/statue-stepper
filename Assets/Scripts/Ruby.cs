using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    // Start is called before the first frame update
    float rotspeed = -0.75F;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotspeed * Time.deltaTime * 60, 0, Space.World);
    }

}
