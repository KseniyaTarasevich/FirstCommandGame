using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 10f;
    [SerializeField] float _jumpForce = 10f;

    private new Rigidbody2D rigidbody;
    private SpriteRenderer sprite;
    private Animator animator;

    private bool _isPlatform = false;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public enum CharacterState
    {
        Idle, Run, Jump
    }

    private CharacterState State
    {
        get
        {
            return (CharacterState)animator.GetInteger("State");
        }

        set
        {
            animator.SetInteger("State", (int)value);
        }
    }


    void Update()
    {
        State = CharacterState.Idle;
        if (Input.GetButton("Horizontal"))
        {
            Run();


        }
        if (Input.GetButtonDown("Jump"))

        {
            Jump();
        }

    }

    private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, _speed * Time.deltaTime);
        sprite.flipX = direction.x > 0;

        State = CharacterState.Run;

    }

    private void Jump()
    {
        rigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
    }

}