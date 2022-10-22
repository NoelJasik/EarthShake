using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float jumpForce;

    bool canJump;
    Rigidbody rb;

[SerializeField]
float kayoteTime;
    float kayoteTimer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        kayoteTimer -= Time.deltaTime;
        if(kayoteTimer > 0)
        {
            canJump = true;
        } else
        {
            canJump = false;
        }
        float moveHor = Input.GetAxis("Horizontal") * moveSpeed;
        float moveVer = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector3(moveHor, rb.velocity.y, moveVer);
        if(canJump && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpForce * transform.up);
            kayoteTimer = 0;
            canJump = false;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if(other.transform.tag == "Ground")
        {
            canJump = true;
            kayoteTimer = kayoteTime;
        }
           if(other.transform.tag == "Lava")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
