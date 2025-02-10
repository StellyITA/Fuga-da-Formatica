using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freefall : MonoBehaviour
{
    [SerializeField] private GameObject _thoughtCanvas;
    [SerializeField] private GameObject _nextPicture;

    private void Update()
    {
        if (!_thoughtCanvas.activeSelf)
        {
            _nextPicture.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
