using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WindowSettings : MonoBehaviour
{
    [Header("UI References")]
    public Button fullscreenButton;
    public TextMeshProUGUI buttonLabel;

    void Start()
    {
        UpdateButtonLabel();
    }

    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        UpdateButtonLabel();
    }

    void UpdateButtonLabel()
    {
        if (Screen.fullScreen)
            buttonLabel.text = "Switch to Windowed";
        else
            buttonLabel.text = "Switch to Fullscreen";
    }
}
