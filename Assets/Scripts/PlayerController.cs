using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField][Range(0f, 10f)] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 100f;
    [SerializeField] private bool onFloor = false;
    public StateType playerState = StateType.Live;
    public enum StateType { Live, Dead }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.position += Vector2.left * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.position += Vector2.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.Space) && onFloor)
        {
            // Add a vertical force to the player.
            onFloor = false;
            rigidbody.AddForce(new Vector2(0f, jumpForce));
        }
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
