﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
