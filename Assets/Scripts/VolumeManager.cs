using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void SetMasterVolume(float volume)
    {
        _audioMixer.SetFloat("masterVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        _audioMixer.SetFloat("musicVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        _audioMixer.SetFloat("sfxVolume", volume);
    }
}
