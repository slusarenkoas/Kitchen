using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private GameObject _lampRoot;
    [SerializeField] private GameObject _prefab;
    
    private void Awake()
    {
        Instantiate(_prefab,_lampRoot.transform);
    }
}