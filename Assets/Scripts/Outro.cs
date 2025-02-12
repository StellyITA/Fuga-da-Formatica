using UnityEngine;
using UnityEngine.UI;

public class Outro : MonoBehaviour
{
    [SerializeField] private Sprite[] _pictures = new Sprite[4];
    [SerializeField] private Image _currentPicture;

    [SerializeField] private GameObject _dialogueCanvas;
    [SerializeField] private GameObject _dialogueKeyCanvas;
    [SerializeField] private GameObject _dialogueLidCanvas;
    [SerializeField] private GameObject _dialogueHorrorCanvas;

    [SerializeField] private GameObject _Outro;


    private int _currentPictureIndex = 0;

    public void OnBinClick()
    {

        switch (_currentPictureIndex)
        {
            case 0:
            case 1:
                _currentPictureIndex++;
                _currentPicture.sprite = _pictures[_currentPictureIndex];

                if (_currentPictureIndex == 1)
                {

                    _dialogueCanvas.SetActive(true);
                }

                break;
            case 2:

                if (_currentPictureIndex == 2)
                {
                    _dialogueKeyCanvas.SetActive(true);
                }

                _currentPictureIndex++;

                break;
            case 3:
                _currentPicture.sprite = _pictures[_currentPictureIndex];

                _dialogueLidCanvas.SetActive(true);
                _currentPictureIndex++;
                break;

            case 4:
                _currentPicture.sprite = _pictures[_currentPictureIndex];
                _dialogueHorrorCanvas.SetActive(true);
                _currentPictureIndex++;
                break;

            case 5:
                _Outro.SetActive(false);

                break;
        }
    }

}

