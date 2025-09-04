using UnityEngine;
using CodeMonkey; // <--- ADD THIS LINE
using CodeMonkey.Utils;

public class BirdHandler : MonoBehaviour
{
    // Changed this to a more reasonable value. Adjust in the Inspector!
    [SerializeField] private float jumpAmount = 100f;

    private Rigidbody2D birdRigidbody2D;

    private void Awake()
    {
        birdRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    // Jump Func - Cleaned up to use only one method
    private void Jump()
    {
        // Reset vertical velocity for a consistent jump
        birdRigidbody2D.linearVelocity = Vector2.zero;
        
        // Apply a single, instant upward force
        birdRigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        // This will now work correctly!
        // Debug.Log("Dead!"); // Good for testing in the console
        CMDebug.TextPopupMouse("Dead!");
    }
}
