using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    [SerializeField] private GameObject _lampRoot;
    private Lamp[] _lamps;

    private void Start()
    {
        _lamps = _lampRoot.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
}