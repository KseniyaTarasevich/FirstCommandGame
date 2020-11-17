using UnityEngine;
using UnityEngine.SceneManagement;

public class RockScript : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private SpriteRenderer sprite;
    private static int rockCount = 0;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            rockCount++;

            Debug.Log(rockCount);
        }

        if (rockCount == 5)
        {
            SceneManager.LoadScene("Titers");
            rockCount = 0;
        }

    }

}
