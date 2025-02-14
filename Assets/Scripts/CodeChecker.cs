using UnityEngine;
using TMPro;

public class CodeChecker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tryText;
    [SerializeField] private GameObject _nextPicture;
    [SerializeField] private AudioSource _rightAudioSource;
    [SerializeField] private AudioSource _wrongAudioSource;
    private string _code = "701";
    private string _tryCode = "";
    private bool _isMatch = false;

    public void SetTryCode(int num)
    {
        if (_tryCode.Length < 3)
        {
            _tryCode += num;
            _tryText.text = _tryCode;
        }

        if (_tryCode.Length == 3)
        {
            if (_tryCode == _code)
            {
                _isMatch = true;
                _nextPicture.SetActive(true);

                _rightAudioSource.Play();

                gameObject.SetActive(false);
            }
            else
            {
                _tryCode = "";
                _tryText.text = "";
                _wrongAudioSource.Play();
            }
        }
    }

    public bool GetIsMatch()
    {
        return _isMatch;
    }

}
