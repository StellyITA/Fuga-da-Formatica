using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private bool _hasKey = false;
    private bool _isTextPanelActive = false;

    public void OnTextPanelClick()
    {
        if (_isTextPanelActive)
        {
            _isTextPanelActive = false;
        }
    }

    public bool GetTextPanelActive()
    {
        return _isTextPanelActive;
    }

    public void SetTextPanelActive(bool isActive)
    {
        _isTextPanelActive = isActive;
    }

    public bool GetHasKey()
    {
        return _hasKey;
    }

    public void SetHasKey(bool hasKey)
    {
        _hasKey = hasKey;
    }
}
