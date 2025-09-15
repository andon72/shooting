using UnityEngine;

public class Pbullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _brb;
    private void OnEnable()
    {
        _brb.linearVelocity = new Vector2(5f, 0f);
    }
    private void Update()
    {
        if (transform.position.x > 3.6)
        {
            Destroy(gameObject);
        }
    }
}
