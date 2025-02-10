using UnityEngine;

public class VMCorrectCode : MonoBehaviour
{
    [SerializeField] private CodeChecker _codeChecker;
    [SerializeField] private Thoughts _thoughts;
    private bool _hasShownThought = false;

    private void OnEnable()
    {
        if (_codeChecker.GetIsMatch() && !_hasShownThought)
        {
            _thoughts.SetCurrentThought(1);
            _thoughts.OnThoughtClick();
            _hasShownThought = true;
        }
    }
}
