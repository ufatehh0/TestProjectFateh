using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public float moveSpeed = 5f;

    
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }


    public void OnTest()
    {
        Debug.Log("Test");

    }

    public void OnFire()
    {
        Debug.Log("Fire");
        
    }

    void Update()
    {
        
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}