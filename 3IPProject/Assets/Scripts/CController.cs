using UnityEngine;

public class CController : MonoBehaviour
{
    public Animator animator;
    public float movementSpeed = 1;
    public float jumpForce = 1;
    
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement));

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }
       
    }
}
