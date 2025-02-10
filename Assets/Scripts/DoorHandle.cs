using UnityEngine;
using TMPro;

public class DoorHandle : MonoBehaviour
{
    [SerializeField] private PlayerState _playerState;
    [SerializeField] private GameObject _currentRoom;
    [SerializeField] private GameObject _nextRoom;
    [SerializeField] private GameObject _textPanel;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private string _doorClosed;

    public void OnHandleClick()
    {
        if (_playerState.GetHasKey())
        {
            _nextRoom.SetActive(true);
            _currentRoom.SetActive(false);
            _playerState.SetHasKey(false);
        }
        else
        {
            _textPanel.SetActive(true);
            _text.text = _doorClosed;
            _playerState.SetTextPanelActive(true);
        }
    }
}
