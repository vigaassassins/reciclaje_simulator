using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    int number;
    // Start is called before the first frame update
    void Start()
    {
        materiapawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3();
        }
    }

    public void materiapawn()
    {
        number = Random.Range(1, 8);
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
