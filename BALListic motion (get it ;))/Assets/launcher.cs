using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class launcher : MonoBehaviour
{
    public double a0 = 1;
    public double v0 = 1;
    public double mass = 1;

    void Start()
    {
        GameObject burger = GameObject.Find("Bruh");
        Rigidbody rb = GetComponent<Rigidbody>();
        a0 = burger.GetComponent<godCube>().a0;
        v0 = burger.GetComponent<godCube>().v0;
        mass = burger.GetComponent<godCube>().mass;

        double F = rb.mass * v0 * 60;

        double x_force = Math.Cos((a0 * Math.PI) / 180) * F;
        double y_force = Math.Sin((a0 * Math.PI) / 180) * F;

        rb.AddForce(Convert.ToSingle(1f * x_force), Convert.ToSingle(1f * y_force), 0f);
    }
}
