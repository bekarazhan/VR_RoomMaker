﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
 

    public void GoBackMainMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
