using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    [SerializeField] private GameObject _lampRoot;
    private Lamp[] lamps;

    private void Start()
    {
        lamps = _lampRoot.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in lamps)
            {
                lamp.Interact();
            }
        }
    }
}