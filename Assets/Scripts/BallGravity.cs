using UnityEngine;
using UnityEngine.SceneManagement;

public class BallGravity : MonoBehaviour
{
    Vector2 _EarthGravity = new Vector2(0, -9.8f);
    Vector2 _MoonGravity = new Vector2(0, -1.6f);
    Vector2 _JupiterGravity = new Vector2(0, -24.5f);
    Vector2 _mousePos;
    Rigidbody2D rb;
    string _planetName;
    int counter;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb.velocity = new Vector2(_mousePos.x, transform.position.y);
        }
        _planetName = PlayerPrefs.GetString("Planet");
        if (_planetName == "Earth")
        {
            Earth();
        }
        if (_planetName == "Moon")
        {
            Moon();
        }
        if (_planetName == "Jupiter")
        {
            Jupiter();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            UI();
        }
    }

    void Earth()
    {
        Physics2D.gravity = _EarthGravity;
        rb.drag = .3f;
    }

    void Moon()
    {
        Physics2D.gravity = _MoonGravity;
        rb.drag = .06f;
    }

    void Jupiter()
    {
        Physics2D.gravity = _JupiterGravity;
        rb.drag = 1.5f;
    }
    void UI()
    {
        SceneManager.LoadScene("menu");
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "platform")
        {
            counter = PlayerPrefs.GetInt("counter");
            counter++;
            PlayerPrefs.SetInt("counter", counter);
            Debug.Log(counter);
        }
    }
}
