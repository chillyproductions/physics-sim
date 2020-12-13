using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godCube : MonoBehaviour
{
    public double a0=1;
    public double v0=1;
    public double mass=1;
    public double frameRate = 1;

    void Start()
    {
        this.transform.position = new Vector3(-100, -100, -100);
    }
    public void setVars(double a00, double v00, double mass0, double frameRate0)
    {
        this.a0 = a00;
        this.v0 = v00;
        this.mass = mass0;
        this.frameRate = frameRate0;
        DontDestroyOnLoad(this.gameObject);
    }
}
