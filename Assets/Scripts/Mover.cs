using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private float _speed;

    private void Update()
    {
        MovingForward(_sphere);
    }

    private void MovingForward(Transform movable)
    {
        var nextPosition = movable.position;
        nextPosition.z += _speed;
        movable.position = nextPosition;
    }
}
