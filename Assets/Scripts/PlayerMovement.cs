using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 15f;

    private Rigidbody rb;
    private Vector3 moveInput;


    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        moveInput = Vector3.ClampMagnitude(new Vector3(moveX, 0f, moveZ), 1f);
    }

    void FixedUpdate()
    {
        rb.AddForce(moveInput * moveForce, ForceMode.Force);

    }
}
