using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMeter : MonoBehaviour
{
    public bool inBattle;

    public void ToggleBattle()
    {
        if (inBattle)
        {
            //Set colour to red
            gameObject.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }
        else
        {
            //Set colour to blue
            gameObject.GetComponent<Image>().color = new Color32(0, 0, 255, 100);
        }
    }
}
