using UnityEngine;
using TMPro;

public class TextScaler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private Vector2 referenceResolution = new Vector2(1920, 1080); // Risoluzione di riferimento

    void Start()
    {
        AdjustTextSize();
    }

    void AdjustTextSize()
    {
        // Calcola il fattore di scala in base alla risoluzione attuale
        float scaleFactor = Mathf.Min(Screen.width / referenceResolution.x, Screen.height / referenceResolution.y);

        // Applica il fattore di scala alla dimensione del testo
        text.fontSize *= scaleFactor;
    }
}
