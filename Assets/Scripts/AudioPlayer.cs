using System.Collections;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private int _secondsToPlay = 0;
    [SerializeField] private int _secondsToCutAtPlay = 0;
    [SerializeField] private bool _isMusic;

    private void Awake()
    {
        if (_isMusic)
        {
            StartCoroutine("LoopMusicCoroutine");
        }
    }

    private IEnumerator LoopMusicCoroutine()
    {
        _audioSource.time = _secondsToCutAtPlay;
        float volume = _audioSource.volume;

        while (true)
        {
            _audioSource.Play();
            yield return new WaitForSeconds(_secondsToPlay);
            _audioSource.Stop();
        }
    }

    public void PlayAudio()
    {
        _audioSource.time = _secondsToCutAtPlay;
        _audioSource.Play();
        if (_secondsToPlay > 0) Invoke("StopAudio", _secondsToPlay);
    }

    private void StopAudio()
    {
        _audioSource.Stop();
    }
}
