using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform _target;


    private void Start()
    {
         if (!_target)
         {
             _target = FindObjectOfType<PlayerController>().transform;
         }
    }

    private void Update()
    {
        Vector3 position = _target.position;
        position.z = -10.0f;
        position.y-= 1.0f;
        transform.position = Vector3.Lerp(transform.position, position, _speed * Time.deltaTime);

    }
}
