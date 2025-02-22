﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLoader : MonoBehaviour
{
    public void LoadKitchenScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("KitchenScene"); //Load kitchen scene
    }

    public void LoadMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu"); //Load menu scene
    }

    public void LoadLivingRoomScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LivingRoomScene"); //Load living room scene
    }

    public void LoadTutorialScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial"); //Load tutorial scene
    }

    public void QuitGame()
    {
        Application.Quit(); //Quit game
    }
}
