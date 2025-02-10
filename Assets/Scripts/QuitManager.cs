using UnityEngine;

public class QuitManager : MonoBehaviour
{
    [SerializeField] private GameObject _askWindow;

    public void OnQuitClick()
    {
        _askWindow.SetActive(true);
    }

    public void OnYesClick()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }

    public void OnNoClick()
    {
        _askWindow.SetActive(false);
    }
}
