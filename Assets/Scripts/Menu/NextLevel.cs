using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private int nextScene_asint;
    private int currScene;
    private string stage;

    [SerializeField]
    public Object nextScene;

    private void Start()
    {
        currScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("CurrScene", currScene);
        PlayerPrefs.SetInt("NextScene", currScene);
        nextScene_asint = currScene + 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && currScene != 10)
        {
            PlayerPrefs.SetInt("available", 1);
            PlayerPrefs.SetInt("NextScene", nextScene_asint);
            // SceneManager.LoadScene(3);

            SceneManager.LoadScene(nextScene.name);
        }
        else if(collision.collider.tag == "Player" && currScene == 10)
        {
            nextScene = 4;
            currScene = 4;
            PlayerPrefs.SetInt("CurrScene", currScene);
            PlayerPrefs.SetInt("NextScene", currScene);
            SceneManager.LoadScene(3);
            
        }
    }
    
  
}       
