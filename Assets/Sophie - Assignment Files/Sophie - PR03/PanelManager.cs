using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject settingsPanel;
    public GameObject audioPanel;

    void Start()
    {
        // Show only the main menu at the start
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(false);
        audioPanel.SetActive(false);
    }

    public void ShowGame()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(true);
        settingsPanel.SetActive(false);
        audioPanel.SetActive(false);
    }

    public void ShowSettings()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(true);
        audioPanel.SetActive(false);
    }

    public void ShowAudio()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(false);
        audioPanel.SetActive(true);
    }
}
