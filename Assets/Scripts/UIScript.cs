using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    string _planetName;
    public void EarthButton()
    {
        PlayerPrefs.DeleteAll();
        _planetName = "Earth";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }

    public void MoonButton()
    {
        PlayerPrefs.DeleteAll();
        _planetName = "Moon";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }

    public void JupiterButton()
    {
        PlayerPrefs.DeleteAll();
        _planetName = "Moon";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }
}
