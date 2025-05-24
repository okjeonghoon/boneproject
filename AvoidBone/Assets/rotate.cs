using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public Rigidbody2D rigid;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.AddTorque(rotateSpeed);
    }
}
