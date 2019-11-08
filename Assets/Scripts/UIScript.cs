using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text _counterText;
    string _planetName;
    int counter;
    bool _firstStart;
    void Start()
    {  
        
    }
    void Update()
    {
        counter = PlayerPrefs.GetInt("counter");
        _counterText.text = counter.ToString();
    }

    public void EarthButton()
    {
        PlayerPrefs.DeleteKey("Planet");
        _planetName = "Earth";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }

    public void MoonButton()
    {
        PlayerPrefs.DeleteKey("Planet");
        _planetName = "Moon";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }

    public void JupiterButton()
    {
        PlayerPrefs.DeleteKey("Planet");
        _planetName = "Jupiter";
        PlayerPrefs.SetString("Planet", _planetName);
        SceneManager.LoadScene("main");
    }
    public void ExitButton()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
