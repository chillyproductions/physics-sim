using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class generalScene : MonoBehaviour
{
    public GameObject theOne;
    public GameObject theOneTwo;
    public GameObject Sphere;

    public List<double> xArr = new List<double>();
    public List<double> yArr = new List<double>();

    void Start()
    {
        GameObject yLabel = GameObject.Find("yLabel1");
        GameObject xLabel = GameObject.Find("xLabel1");
        //TextMesh yLabel1 = yLabel.GetComponent<TextMesh>();
        Vector3 Temp = theOneTwo.transform.position;
        for(int i=2; i<=54; i++)
        {
            if (i < 30)
            {
                GameObject theOther = GameObject.Instantiate(theOne);
                theOther.transform.position = new Vector3(0, i, 0);
                GameObject otherLabel = GameObject.Instantiate(yLabel);
                otherLabel.GetComponent<TextMesh>().text = i.ToString();
                otherLabel.transform.position = new Vector3(yLabel.transform.position.x, i, yLabel.transform.position.z);
            }
            GameObject theOtherOne = GameObject.Instantiate(theOneTwo);
            theOtherOne.transform.position = new Vector3(i, Temp.y, 0);

            GameObject otherLabel2 = GameObject.Instantiate(xLabel);
            otherLabel2.GetComponent<TextMesh>().text = i.ToString();
            if (i < 22)
            {
                otherLabel2.transform.position = new Vector3(i + (float)0.5 - 1, xLabel.transform.position.y, xLabel.transform.position.z);
            }
            else if(i<36)
            {
                otherLabel2.transform.position = new Vector3(i + (float)0.70 - 1, xLabel.transform.position.y, xLabel.transform.position.z);
            }
            else { otherLabel2.transform.position = new Vector3(i, xLabel.transform.position.y, xLabel.transform.position.z); }
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

        System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +@"\XArray", str_arr);

    }
    public void downloadY()
    {
        string[] str_arr = Array.ConvertAll(yArr.ToArray(), x => x.ToString());

        System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\YArray", str_arr);

    }
    public void returnBack()
    {
        SceneManager.LoadScene(0);
    }
}
