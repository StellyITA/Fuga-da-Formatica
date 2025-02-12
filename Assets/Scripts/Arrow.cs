using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private GameObject _currentPicture;
    [SerializeField] private GameObject _nextPicture;
    [SerializeField] private AudioPlayer _audioPlayer;

    public void OnArrowClick()
    {
        _nextPicture.SetActive(true);

        if (_audioPlayer != null)
        {
            _audioPlayer.PlayAudio();
        }

        _currentPicture.SetActive(false);
    }
}
