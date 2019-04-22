using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

[Serializable]
public class UIComponents 
{
    [Serializable]
    public class Hud {

       [Header("Text")]
       public Text txtCoinCount;

       
       [Header("Other")]
       public GameObject panelHud; 
    }

    public Hud hud; 
}
