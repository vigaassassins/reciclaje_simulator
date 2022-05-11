using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MencuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void playclick()
    {

        SceneManager.LoadScene("SampleScene");
    }
    public void quitclick()
    {
        Application.Quit();
    }
    public void retryclick()
    {

        SceneManager.LoadScene("SampleScene");
    }

    public void menuclick()
    {

        SceneManager.LoadScene("menu");
    }
}
