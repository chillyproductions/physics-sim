using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class generalScene : MonoBehaviour
{
    public GameObject theOne;
    public GameObject theOneTwo;
    public GameObject Sphere;

    public List<double> xArr = new List<double>();
    public List<double> yArr = new List<double>();

    void Start()
    {
        Vector3 Temp = theOneTwo.transform.position;
        for(int i=2; i<=50; i++)
        {
            if (i < 25)
            {
                GameObject theOther = GameObject.Instantiate(theOne);
                theOther.transform.position = new Vector3(0, i, 0);
            }
            GameObject theOtherOne = GameObject.Instantiate(theOneTwo);
            theOtherOne.transform.position = new Vector3(i, Temp.y, 0);
        }
    }

    void Update()
    {
        if (Time.timeScale != 0)
        {
            xArr.Add(Sphere.transform.position.x);
            yArr.Add(Sphere.transform.position.y);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void copyX()
    {
        TextEditor te = new TextEditor();
        te.text = string.Join(", ", xArr);
        te.SelectAll();
        te.Copy();
        //Clipboard.SetData(xArr.ToArray());
    }
    public void copyY()
    {
        TextEditor te = new TextEditor();
        te.text = string.Join(", ", yArr);
        te.SelectAll();
        te.Copy();
        //Clipboard.SetData(xArr.ToArray());
    }
    public void downloadX()
    {
        string[] str_arr = Array.ConvertAll(xArr.ToArray(), x => x.ToString());

        System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\uwuXXXARRAYdinosaurfoldersenpai.txt", str_arr);

    }
    public void downloadY()
    {
        string[] str_arr = Array.ConvertAll(yArr.ToArray(), x => x.ToString());

        System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\uwuYYYARRAYdinosaurfoldersenpai.txt", str_arr);

    }
}
