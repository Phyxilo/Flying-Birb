using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirbMovement : MonoBehaviour
{
    public float jumpVel = 2;

    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { rigidBody.velocity = new Vector2(0, jumpVel); }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obs") 
        { 
            Destroy(this.gameObject); SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
