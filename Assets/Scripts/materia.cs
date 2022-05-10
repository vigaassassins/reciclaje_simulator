using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materia : MonoBehaviour
{
    machine gc;
    // Start is called before the first frame update
    bool inmachine;
    private Rigidbody2D rb2d;
    void Start()
    {
        Debug.Log(gameObject.tag);
        inmachine = true;
        rb2d = GetComponent<Rigidbody2D>();
        GameObject obj = GameObject.FindGameObjectWithTag("machine");
        gc = obj.GetComponent<machine>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inmachine = false;
            rb2d.gravityScale = 1;
        }
        //rb2d.gravityScale (addGrav);
        if (inmachine)
        {
            transform.position = gc.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == gameObject.tag)
        {
            Destroy(gameObject);
            gc.materiapawn();
        }
        else
        {
            Debug.Log("Perdiste");
            gc.equivo();
        }
    }
}
