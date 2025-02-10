using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OnCreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Game");
    }
}
