using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Button Continue;
    private static int available;
    private void Start()
    {
        available = PlayerPrefs.GetInt("available");
        
        if (available == 0)
            Continue.gameObject.SetActive(false);
        
        else if (available == 1)
            Continue.gameObject.SetActive(true);
    }
}
