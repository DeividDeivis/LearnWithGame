using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Scriptable Objects IPS/PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    [SerializeField][Range(0f, 10f)] private float moveSpeed = 10f;
    public float MoveSpeed { get { return moveSpeed; } }

    [SerializeField] private float jumpForce = 100f;
    public float JumpForce { get { return jumpForce; } }

    [SerializeField] private int initialHealth = 3;
    public int Health { get { return initialHealth; } }
}
