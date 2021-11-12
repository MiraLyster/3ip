using UnityEngine;

public class CController : MonoBehaviour
{
    public Animator animator;
    public float movementSpeed = 1;
    public float jumpForce = 10;
   // private bool jump = false;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    //public GameObject _rayCast;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement));
        if (movement < 0)
        {
            _spriteRenderer.flipX = true;
        } 
        else if(movement > 0){
            _spriteRenderer.flipX = false;
        }

        /*
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            
            //if (jump == false) jump = true;
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
            
            //Jump flag
        }
        /*
        if (animator.GetBool("IsJumping") && !jump)
        {
            animator.SetBool("IsJumping", false);
        }
        */
    }

    /*
    private void FixedUpdate()
    {
        if (jump)
        {
            RaycastHit2D hit = Physics2D.Raycast(_rayCast.transform.position, Vector2.down);
            Debug.Log(hit.collider.gameObject.name);
            Debug.Log(hit.distance);

            //Calculations for raycasting. Should only be when jumping. Origin, Direction, Distance 
            if(hit.distance == 0.0f)
            {
                jump = false;
                
            }
            //animator.SetBool("IsJumping", jump);
        }
    }
    */
}
