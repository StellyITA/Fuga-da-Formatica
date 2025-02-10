using UnityEngine;

public class ExitCorrectCode : MonoBehaviour
{
    [SerializeField] private CodeChecker _codeChecker;
    [SerializeField] private PlayerState _playerState;

    private void OnEnable()
    {
        if (_codeChecker.GetIsMatch() && !_playerState.GetHasKey())
        {
            _playerState.SetHasKey(true);
        }
    }
}
