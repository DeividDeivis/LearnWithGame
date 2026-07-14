using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.1f;

    private PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();

        moveSpeed++;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(playerController.transform.position, transform.position);
        //Debug.Log("Distance: " + distance);
    }
}
