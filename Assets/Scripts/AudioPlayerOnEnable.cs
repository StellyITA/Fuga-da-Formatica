using UnityEngine;

public class AudioPlayerOnEnable : MonoBehaviour
{
    [SerializeField] private AudioPlayer _audioPlayer;

    private void OnEnable()
    {
        _audioPlayer.PlayAudio();
    }
}
