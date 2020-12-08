using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class launcher : MonoBehaviour
{

    void Start()
    {
        double v0 = 10;
        double ang = 45;
        Rigidbody rb = GetComponent<Rigidbody>();

        double F = rb.mass * v0 * 60;

        double x_force = Math.Cos((ang * Math.PI) / 180) * F;
        double y_force = Math.Sin((ang * Math.PI) / 180) * F;

        rb.AddForce(Convert.ToSingle(1f * x_force), Convert.ToSingle(1f * y_force), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x + ",  " + transform.position.y);
    }
}
