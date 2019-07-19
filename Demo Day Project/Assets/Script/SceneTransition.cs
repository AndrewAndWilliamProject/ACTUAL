using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string GoToScene;
    private float xpos;
    private float ypos;

    void Start()
    {
        xpos = -11.5f;
        ypos = 0f;
    }

    public void OnTriggerEnter2D(Collider2D collider)

    {
        if (collider.CompareTag("Player") && !collider.isTrigger)
        {
            PlayerPrefs.SetFloat("xpos", xpos);
            PlayerPrefs.SetFloat("ypos", ypos);
            SceneManager.LoadScene(GoToScene);
        }
    }
}
