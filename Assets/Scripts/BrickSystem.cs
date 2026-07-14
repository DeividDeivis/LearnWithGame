using UnityEngine;

public class BrickSystem : MonoBehaviour
{
    [SerializeField] private GameObject _bricksSprite;
    [SerializeField] private ParticleSystem _brickParticles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            _bricksSprite.SetActive(false);
            _brickParticles.Play();
        }
    }
}
