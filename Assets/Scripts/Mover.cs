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
    [SerializeField] private Transform _cube;
    [SerializeField] private Transform _capsule;
    [SerializeField] private float _speed;

    private void Start()
    {
        
    }

    private void Update()
    {
        MovingForward(_sphere);
        Rotation(_cube);
        GrowSize(_capsule);
    }

    private void GrowSize(Transform modifiable)
    {
        modifiable.localScale = NextSize(modifiable.localScale, _speed); ;
    }

    private Vector3 NextSize(Vector3 modifiable, float size)
    {
        modifiable.x += size;
        modifiable.y += size;
        modifiable.z += size;
        return modifiable;
    }

    private void Rotation(Transform movable)
    {
        movable.rotation *= Quaternion.Euler(0, _speed, 0);
    }

    private void MovingForward(Transform movable)
    {
        Vector3 nextPosition = movable.position;
        nextPosition.z += _speed;
        movable.position = nextPosition;
    }
}
