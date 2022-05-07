using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materia : MonoBehaviour
{
    machine gc;
    // Start is called before the first frame update
    bool inmachine;
    void Start()
    {
        inmachine = true;
        GameObject obj = GameObject.FindGameObjectWithTag("machine");
        gc = obj.GetComponent<machine>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inmachine)
        {
            transform.position = gc.transform.position;
        }
    }
}
