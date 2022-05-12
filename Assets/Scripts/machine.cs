   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class machine : MonoBehaviour
{
    public GameObject papel1;
    public GameObject papel2;
    public GameObject vidrio1;
    public GameObject vidrio2;
    public GameObject plastico1;
    public GameObject plastico2;
    public GameObject noreci1;
    public GameObject noreci2;

    public TextMeshProUGUI Textscore;
    int number;
    bool getmateria;
    int hp=3;
    // Start is called before the first frame update
    void Start()
    {

        Textscore.text = "HP: " + hp;
        materiapawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            getmateria = false;
        }
            if (getmateria) 
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.position = new Vector3(-6, 3.21f, 0);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position = new Vector3(-2, 3.21f, 0);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position = new Vector3(2, 3.21f, 0);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                transform.position = new Vector3(6, 3.21f, 0);
            }
        }


    }

    public void equivo()
    {
        hp--;
        Debug.Log(hp);
        if (hp > 0)
        {
            materiapawn();
        }
        Textscore.text = "HP: " + hp;
    }

    public void rechar(string mat)
    {
        if (hp<=0)
        {

            if (mat == "plastico")
            {
                SceneManager.LoadScene("mat1plas"); 
            }
            else if (mat == "vidrio")
            {
                SceneManager.LoadScene("mat1nore");
            }

            else if (mat == "noreci")
            {
                SceneManager.LoadScene("mat1inorg");

            }
            else if (mat == "papel")
            {
                SceneManager.LoadScene("mat1pilas");
            }
        }
    }
    public void materiapawn()
    {
        number = Random.Range(1, 8);
        transform.position = new Vector3(0, 3.21f, 0);
        getmateria = true;
        switch (number)
        {
            case 1:
                Instantiate(papel1);
                break;
            case 2:
                Instantiate(papel2);
                break;
            case 3:
                Instantiate(vidrio1);
                break;
            case 4:
                Instantiate(vidrio2);
                break;
            case 5:
                Instantiate(plastico1);
                break;
            case 6:
                Instantiate(plastico2);
                break;
            case 7:
                Instantiate(noreci1);
                break;
            case 8:
                Instantiate(noreci2);
                break;
        }
    }
}
