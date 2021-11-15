using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] string scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            SceneManager.LoadScene(scene);
        
    }
}       
