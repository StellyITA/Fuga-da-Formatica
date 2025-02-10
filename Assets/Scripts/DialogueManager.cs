using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [TextArea]
    [SerializeField] private string[] _lines;
    [SerializeField] private TextMeshProUGUI _lineText;
    private int _currentLineIndex = 0;

    private void OnEnable()
    {
        StartCoroutine("TextCoroutine");
    }

    public void OnWriteDialogue()
    {
        if (_currentLineIndex >= _lines.Length)
        {
            gameObject.SetActive(false);
        }
        else if (_lineText.text == "")
        {
            StartCoroutine("TextCoroutine");
        }
        else if (_lineText.text != _lines[_currentLineIndex])
        {
            StopCoroutine("TextCoroutine");
            _lineText.text = _lines[_currentLineIndex];
        }
        else if (_lineText.text == _lines[_currentLineIndex])
        {
            _lineText.text = "";
            _currentLineIndex++;
            OnWriteDialogue();
        }
    }

    private IEnumerator TextCoroutine()
    {
        int characterIndex = 0;
        while (_currentLineIndex < _lines.Length && characterIndex < _lines[_currentLineIndex].Length)
        {
            _lineText.text += _lines[_currentLineIndex][characterIndex];
            characterIndex++;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
