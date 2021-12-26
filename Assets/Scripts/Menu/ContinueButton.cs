using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Button Continue;
    [SerializeField] private int available = 0;
    private void Awake()
    {
        available = PlayerPrefs.GetInt("available");
        if (available == 0)
        {
            Continue.gameObject.SetActive(false);
            available = 1;
        }
        else if (available == 1)
            Continue.gameObject.SetActive(true);
    }
}
