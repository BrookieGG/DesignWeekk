using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FirstPlanet()
    {
        SceneManager.LoadScene("1");
    }
    public void SecondPlanet()
    {
        SceneManager.LoadScene("2");
    }
    public void ThirdPlanet()
    {
        SceneManager.LoadScene("3");
    }
    public void FourthPlanet ()
    {
        SceneManager.LoadScene("4");
    }
    public void FifthPlanet()
    {
        SceneManager.LoadScene("5");
    }
}
