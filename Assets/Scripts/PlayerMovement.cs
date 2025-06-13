using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementInput;
    private Rigidbody2D playerRB;
    [Serialize]private float xVelocity = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = Input.GetAxis("Horizontal");
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.linearVelocityX = movementInput * xVelocity;
    }
}
