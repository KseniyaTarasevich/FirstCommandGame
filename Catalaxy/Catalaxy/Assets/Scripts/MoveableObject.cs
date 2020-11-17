using UnityEngine;

public class MoveableObject : MonoBehaviour
{

    [SerializeField] Vector2 movePosition;
    [SerializeField] float moveSpeed;
    Vector2 startPosition;


    void Start()
    {
        startPosition = transform.position;
    }


    void Update()
    {
        transform.position = startPosition + movePosition * Mathf.PingPong(Time.time * moveSpeed, 1.5f); ;
    }
}
