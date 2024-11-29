using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoToMonuments()
    {
        SceneManager.LoadScene("Monuments");
    }
    public void GoToMuseums()
    {
        SceneManager.LoadScene("Museums");
    }
    public void GoToEvents()
    {
        SceneManager.LoadScene("Events");
    }
}
