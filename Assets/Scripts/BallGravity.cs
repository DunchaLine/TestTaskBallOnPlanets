using UnityEngine;

public class BallGravity : MonoBehaviour
{
    Vector2 _EarthGravity = new Vector2(0, -9.8f);
    Vector2 _MoonGravity = new Vector2(0, -1.6f);
    Vector2 _JupiterGravity = new Vector2(0, -24.5f);
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void Earth()
    {
        Physics2D.gravity = _EarthGravity;
    }

    void Moon()
    {
        Physics2D.gravity = _MoonGravity;
    }

    void Jupiter()
    {
        Physics2D.gravity = _JupiterGravity;
    }
}
