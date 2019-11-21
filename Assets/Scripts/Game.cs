using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public string firstLevel;


    void Start()
    {
        SceneManager.LoadScene(firstLevel, LoadSceneMode.Additive);
    }

    void Update()
    {
        
    }
}
