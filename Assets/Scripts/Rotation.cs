using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
      transform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}
