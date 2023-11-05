using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf[] _shelfs;
    
    private const int MAX_COUNT_DISHES_ON_ONE_SHELF = 3;
    private readonly Dictionary<Shelf, int> _itemsOnShelf = new ();

    private void Awake()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += OnItemSpawned;
        }
    }

    private void OnDestroy()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned -= OnItemSpawned;
        }
    }
    
    private void OnItemSpawned(Shelf shelf)
    {
        _itemsOnShelf.TryAdd(shelf, 0);
        _itemsOnShelf[shelf]++;
        
        if (_itemsOnShelf[shelf] > MAX_COUNT_DISHES_ON_ONE_SHELF)
        {
            shelf.Fall();
        }
    }
    
    
    
    
}