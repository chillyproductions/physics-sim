using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public string simScene;

    public double a0 ;
    public double v0;
    public double mass;

    public GameObject velocityField;
    public GameObject alphaField;
    public GameObject massField;
    public GameObject burger;


    public void startSim()
    {
        a0 = double.Parse(alphaField.GetComponent<Text>().text);
        v0 = double.Parse(velocityField.GetComponent<Text>().text);
        mass = double.Parse(massField.GetComponent<Text>().text);
        burger.GetComponent<godCube>().setVars(a0, v0, mass);
        SceneManager.LoadScene(simScene);
    }

    public void quitSim()
    {
        Application.Quit();
    }


}
