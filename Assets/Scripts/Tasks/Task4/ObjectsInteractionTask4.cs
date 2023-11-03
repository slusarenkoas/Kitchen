using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject _waffleRoot;
    [SerializeField] private GameObject _prefabWaffle;

    private bool _isCooked = false;
    
    private void OnEnable()
    {
        Toaster.TimerIsUp += CookWaffle;
    }

    private void OnDisable()
    {
        Toaster.TimerIsUp -= CookWaffle;
    }

    private void CookWaffle()
    {
        if (!_isCooked)
        {
            Instantiate(_prefabWaffle, _waffleRoot.transform);
            _isCooked = true;
        }
        
    }
}