using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioEffectsController : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Call this from a UI Slider's OnValueChanged event
    public void SetReverb(float value)
    {
        audioMixer.SetFloat("ReverbRoom", value);
    }

    public void SetPitch(float value)
    {
        audioMixer.SetFloat("PitchShift", value);
    }

    public void SetEcho(float value)
    {
        audioMixer.SetFloat("EchoDelay", value);
    }
}
