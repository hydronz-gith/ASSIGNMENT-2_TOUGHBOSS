using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Call this from a UI Slider's OnValueChanged event
    public void SetVolume(float value)
    {
        audioMixer.SetFloat("Volume", value);
    }
}

