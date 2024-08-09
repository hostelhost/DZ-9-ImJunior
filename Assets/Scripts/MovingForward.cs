using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _nextPosition;

    private void Update()
    {
        _nextPosition = transform.position;
        _nextPosition.z += _speed;
        transform.position = _nextPosition;
    }
}
