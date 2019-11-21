﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButtonClick() => SceneManager.LoadScene("GameScene");
    
    public void OnQuitButtonClick() => Application.Quit();
}
