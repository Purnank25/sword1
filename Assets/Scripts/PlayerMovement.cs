using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticleInput;
    [SerializeField] public float jumpForce = 3.0f;
    private Rigidbody2D playerRB;
    [SerializeField]private float xVelocity = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        playerRB = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        playerRB.linearVelocityX = xVelocity * horizontalInput;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
