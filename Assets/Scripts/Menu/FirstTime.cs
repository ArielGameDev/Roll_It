using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTime : MonoBehaviour
{
    private static bool firstTime = false;
    
    private void Awake()
    {
        PlayerPrefs.SetInt("available", 0);
        if (!firstTime) 
        { 
            firstTime = true;
        } 
        else
            PlayerPrefs.SetInt("available", 1); Debug.Log("active");

    }
}
