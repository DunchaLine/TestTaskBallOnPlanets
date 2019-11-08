using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColor : MonoBehaviour
{
    SpriteRenderer _renderer;
    void Start()
    {
        _renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _renderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
