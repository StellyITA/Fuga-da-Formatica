using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _sfxVolumeSlider;

    private const string MasterVolumeKey = "masterVolume";
    private const string MusicVolumeKey = "musicVolume";
    private const string SfxVolumeKey = "sfxVolume";

    private void Start()
    {
        // Load saved volume preferences and set sliders accordingly
        _masterVolumeSlider.value = PlayerPrefs.GetFloat(MasterVolumeKey, 0.75f); // Default to 0.75
        _musicVolumeSlider.value = PlayerPrefs.GetFloat(MusicVolumeKey, 0.75f);
        _sfxVolumeSlider.value = PlayerPrefs.GetFloat(SfxVolumeKey, 0.75f);

        // Apply the volumes to the Audio Mixer
        SetMasterVolume(_masterVolumeSlider.value);
        SetMusicVolume(_musicVolumeSlider.value);
        SetSfxVolume(_sfxVolumeSlider.value);
    }

    public void SetMasterVolume(float value)
    {
        _audioMixer.SetFloat(MasterVolumeKey, Mathf.Log10(value) * 20); // Convert linear slider value to decibels
        PlayerPrefs.SetFloat(MasterVolumeKey, value);
    }

    public void SetMusicVolume(float value)
    {
        _audioMixer.SetFloat(MusicVolumeKey, Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat(MusicVolumeKey, value);
    }

    public void SetSfxVolume(float value)
    {
        _audioMixer.SetFloat(SfxVolumeKey, Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat(SfxVolumeKey, value);
    }

    private void OnDestroy()
    {
        // Ensure preferences are saved when the object is destroyed
        PlayerPrefs.Save();
    }
}

