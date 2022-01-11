using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    private Animator anim;
    private bool grounded = true;
    private int jumpCounter = 0;
    private int maxJumps = 2;
    private bool canSecondJump;

    public bool onMovingEnemy { get;set; }

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector3(horizontalInput * speed,body.velocity.y);

        //FlipTransform
        if(onMovingEnemy == false)
        {
            if (horizontalInput > 0.01f)
                transform.localScale = new Vector3(1 * Mathf.Abs(body.transform.localScale.x), 1 * body.transform.localScale.y, 1 * body.transform.localScale.z);
            else if (horizontalInput < -0.01f)

                transform.localScale = new Vector3(-1 * Mathf.Abs(body.transform.localScale.x), 1 * body.transform.localScale.y, 1 * body.transform.localScale.z);
        }
                       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(grounded)
            {
                Jump();
                canSecondJump = true;
            }
            else if (canSecondJump)
            {
                Jump();
                canSecondJump = false;
                
                
            }
            
        }
            


        //Set animator parameters
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("Grounded", grounded);
        body.freezeRotation = true;
        
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        anim.SetTrigger("Jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
       if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Block")
            grounded = true;

    }

}
