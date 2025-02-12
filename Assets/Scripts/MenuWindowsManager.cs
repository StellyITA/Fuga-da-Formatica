using UnityEngine;

public class MenuWindowsManager : MonoBehaviour
{
    [SerializeField] private GameObject _window;

    public void OnButtonClick()
    {
        _window.SetActive(true);
    }

    public void OnYesQuitClick()
    {
        Application.Quit();
    }

    public void OnCloseClick()
    {
        _window.SetActive(false);
    }
}
