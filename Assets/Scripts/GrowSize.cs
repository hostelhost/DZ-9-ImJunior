using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GrowSize : MonoBehaviour
{
    [SerializeField] private float _speedSize;

    private void Update()
    {
        transform.localScale = NextSize(transform.localScale);
    }

    private Vector3 NextSize(Vector3 modifiable)
    {
        modifiable.x += _speedSize;
        modifiable.y += _speedSize;
        modifiable.z += _speedSize;
        return modifiable;
    }
}
