using UnityEngine;
using UnityEngine.UI;

public class BinLid : MonoBehaviour
{
    [SerializeField] private Sprite[] _pictures = new Sprite[3];
    [SerializeField] private Image _currentPicture;
    [SerializeField] private PlayerState _playerState;
    [SerializeField] private Thoughts _thoughts;
    [SerializeField] private GameObject _dialogueCanvas;
    [SerializeField] private GameObject _dialogueKeyCanvas;
    [SerializeField] private GameObject _dialogueLidCanvas;
    [SerializeField] private GameObject _dialogueClosedLidCanvas;
    private int _currentPictureIndex = 0;

    public void OnBinClick()
    {
        if (!_playerState.GetHasKey())
        {
            switch (_currentPictureIndex)
            {
                case 0:
                case 1:
                    _currentPictureIndex++;
                    _currentPicture.sprite = _pictures[_currentPictureIndex];

                    if (_currentPictureIndex == 1)
                    {
                        _thoughts.SetCurrentThought(1);
                        _dialogueCanvas.SetActive(true);
                    }

                    if (_currentPictureIndex == 2)
                    {
                        _dialogueKeyCanvas.SetActive(true);
                    }

                    break;
                case 2:
                    _playerState.SetHasKey(true);
                    _currentPictureIndex--;
                    _currentPicture.sprite = _pictures[_currentPictureIndex];
                    _dialogueLidCanvas.SetActive(true);
                    break;
            }
        }
        else
        {
            _currentPictureIndex = 0;
            _currentPicture.sprite = _pictures[0];
            gameObject.SetActive(false);
            _dialogueClosedLidCanvas.SetActive(true);
        }
    }
}
