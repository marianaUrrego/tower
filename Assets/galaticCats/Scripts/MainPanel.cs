using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject instructionsPanel;
    public GameObject creditsPanel;
    public GameObject levelSelectPanel;
   

    public void OpenPanel( GameObject panel)
    {
        mainPanel.SetActive(false);
        instructionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);

        panel.SetActive(true);
    }
}
