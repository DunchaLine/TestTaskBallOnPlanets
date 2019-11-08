using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Color _earthColor, _moonColor, _jupiterColor;
    string _planetName;
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        _planetName = PlayerPrefs.GetString("Planet");
        if (_planetName == "Earth")
        {
            EarthColor();
        }
        if (_planetName == "Moon")
        {
            MoonColor();
        }
        if (_planetName == "Jupiter")
        {
            JupiterColor();
        }
    }
    void EarthColor()
    {
        cam.backgroundColor = _earthColor;
    }
    void MoonColor()
    {
        cam.backgroundColor = _moonColor;
    }
    void JupiterColor()
    {
        cam.backgroundColor = _jupiterColor;
    }
}
