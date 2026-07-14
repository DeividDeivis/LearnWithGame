using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField][Range(0f, 10f)] private float moveSpeed = 10f;
    //[SerializeField] private float jumpForce = 100f;

    [SerializeField] private List<PlayerSettings> settings;

    [SerializeField] private bool onFloor = false;
    public StateType playerState = StateType.Live;
    public enum StateType { Live, Dead }

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private new Rigidbody2D rigidbody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            rigidbody.position += Vector2.left * Time.deltaTime * settings[0].MoveSpeed;
            spriteRenderer.flipX = true;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            rigidbody.position += Vector2.right * Time.deltaTime * settings[0].MoveSpeed;
            spriteRenderer.flipX = false;
        }

        //Debug.Log("Input Axis: " + Input.GetAxis("Horizontal"));
        animator.SetFloat("Input", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetKey(KeyCode.Space) && onFloor)
        {
            // Add a vertical force to the player.
            onFloor = false;
            rigidbody.AddForce(new Vector2(0f, settings[0].JumpForce));
        }

        animator.SetBool("OnFloor", onFloor);

        //Debug.Log("Normalized Player pos: " + transform.position.normalized);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
            onFloor = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
            onFloor = false;
    }
}
