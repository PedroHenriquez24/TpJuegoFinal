using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Objetivo 1")
        {
            if (scoreCounter != null)
                scoreCounter.SumarPuntos(10);

            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
