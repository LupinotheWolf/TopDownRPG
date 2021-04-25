using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class HPText : MonoBehaviour
{
    public Lupino lupino;
    public TextMeshProUGUI hpText;
    public int healthToDisplay;
    public string textToDisplay;

    void Start()
    {
        lupino.OnHealthUpdate += UpdateText;
        UpdateText();
     }
    private void OnDisable()
    {
        lupino.OnHealthUpdate -= UpdateText;
    }
    void UpdateText()
    {

        if (lupino.lupino.status == "LowHealth")
        {
            hpText.color = new Color32(255, 0, 0, 255);
        }
        else if (lupino.lupino.status == "Dead")
        {
            hpText.color = new Color32(255, 0, 0, 255);
        }
        else if (lupino.lupino.status == "NormalHealth")
        {
            hpText.color = new Color32(0, 232, 10, 255);
        }
        healthToDisplay = lupino.lupino.healthSystem.currentHP;
        hpText.SetText(healthToDisplay.ToString());
    }

}
