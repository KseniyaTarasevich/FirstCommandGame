using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;
    private new Rigidbody2D rigidbody;
    public Vector3 savedPosition;
    

    private void Start()
    {
        
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "MainTree")
        {
            savedPosition = other.transform.position;
            Debug.Log(savedPosition);

        }

        if (other.tag == "die" && savedPosition.x != 0f )
        {
            savedPosition = new Vector3(0f, 0f, 0f);
            rigidbody.transform.position = respawn.transform.position;
           
        }
        
       else if(other.tag == "die") SceneManager.LoadScene("Lose");

        
    }

}

