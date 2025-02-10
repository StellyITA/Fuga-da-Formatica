using UnityEngine;
using TMPro;

public class Thoughts : MonoBehaviour
{
    [TextArea]
    [SerializeField] private string[] _thoughts;
    [SerializeField] private GameObject _textPanel;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private PlayerState _playerState;
    private int _currentThoughtIndex = 0;

    private void Awake()
    {
        OnThoughtClick();
    }

    private void Update()
    {
        if (!_playerState.GetTextPanelActive())
        {
            _textPanel.SetActive(false);
        }
    }

    public void OnThoughtClick()
    {
        _playerState.SetTextPanelActive(true);
        _textPanel.SetActive(true);
        _text.text = _thoughts[_currentThoughtIndex];
    }

    public void SetCurrentThought(int index)
    {
        if (index < _thoughts.Length)
        {
            _currentThoughtIndex = index;
        }
    }
}
