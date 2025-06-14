using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   // Physics
    public float jumpForce = 3.0f;
    private float xVelocity = 5.0f;
    // Inputs
    private Rigidbody2D playerRB;
    private float horizontalInput;
    private bool isground;
    // Animation
    private Animator playerAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput >= 0.1f || horizontalInput <= -0.1f)
        {
            playerRB.linearVelocityX = xVelocity * horizontalInput;
            playerAnim.SetBool("isRunning", true);
        }
        else
        {
            playerAnim.SetBool("isRunning", false);
        }
        
        isground 
        if (Input.GetKeyDown(KeyCode.Space) && isground )
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.SetTrigger("jumpTrig");
        }
    }
}
