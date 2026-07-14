using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _sfx;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private SpriteRenderer _sprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            _sfx.Play();

            _collider.enabled = false;
            _sprite.enabled = false;
        }
    }
}
