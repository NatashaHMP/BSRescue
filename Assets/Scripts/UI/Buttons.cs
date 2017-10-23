﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void PlayPress()
    {
        SceneManager.LoadScene(Constants.SceneName.SELECT_LVL);
    }

    public void MenuPress()
    {
        SceneManager.LoadScene(Constants.SceneName.MAIN_MENU);
    }

    public void CreditPress()
    {
        SceneManager.LoadScene(Constants.SceneName.CREDITS);
    }

    public void QuitPress()
    {
        Application.Quit();   
    }

    public void SelectedLvlPress(string numberLvl)
    {
        string nameScenelvl = Constants.SceneName.LVL + numberLvl;

        SceneManager.LoadScene(nameScenelvl);
    }

    public void RestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
