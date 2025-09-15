using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _erb;
    [SerializeField] private BoxCollider2D _eco;
    SerializeField] private MonoBehaviour score;
    private void OnEnable()
    {
        _erb.linearVelocity = new Vector2(-2f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
            Destroy(gameObject);
    }
}
