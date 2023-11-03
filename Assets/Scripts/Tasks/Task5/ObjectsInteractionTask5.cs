using System;
using UnityEditor;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf _shelfOne;
    [SerializeField] private Shelf _shelfTwo;
    private void OnEnable()
    {
        Shelf.ItemSpawned += DestroyShelf;
    }

    private void OnDisable()
    {
        Shelf.ItemSpawned -= DestroyShelf;
    }

    private void DestroyShelf()
    {
        if (_shelfOne.ItemsCount > 3)
        {
            _shelfOne.Fall();
        }

        if (_shelfTwo.ItemsCount > 3)
        {
            _shelfTwo.Fall();
        }
    }
}