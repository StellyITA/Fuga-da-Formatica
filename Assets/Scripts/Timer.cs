using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;
    private int _minutes = 15;
    private int _seconds = 0;
    public GameObject GameOver;

    private void Start()
    {
        InvokeRepeating("CountDown", 1, 1);
    }

    private void Update()
    {
        if (_minutes == 0 && _seconds == 0)
        {
            CancelInvoke("CountDown");
            GameOver.SetActive(true);
        }
    }

    private void CountDown()
    {
        int secondsLeft = (_minutes * 60 + _seconds) - 1;

        if (_minutes != secondsLeft / 60)
        {
            _minutes = secondsLeft / 60;
        }

        _seconds = secondsLeft - _minutes * 60;

        string mins = _minutes > 9 ? "" + _minutes : "0" + _minutes;
        string secs = _seconds > 9 ? "" + _seconds : "0" + _seconds;

        _timerText.text = $"{mins}:{secs}";
    }
}
