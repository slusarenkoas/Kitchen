using System;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    public float Timer { get; private set; } = 10; // Таймер готовности вафли
    private bool _isTimerUp;
    public static event Action TimerIsUp;

    private void Update()
    {
        // Если таймер вышел - выходим из метода
        if (_isTimerUp)
        {
            return;
        }
        
        // Если таймер не вышел
        if (Timer > 0)
        {
            // Отнимаем время, прошедшее за кадр
            Timer -= Time.deltaTime;
        }
        else
        {
            // Таймер вышел
            TimerIsUp?.Invoke();
            _isTimerUp = true;
        }
    }
}