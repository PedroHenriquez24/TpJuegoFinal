using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolaProyectiles : MonoBehaviour
{
    public Transform firePoint;        //punto desde donde sale el proyectil (la punta de la pistola)
    public GameObject proyectilPrefab;    //prefab de la esfera

    [SerializeField] float fuerzaProyectil;   //fuerza con la que sale el proyectil

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * fuerzaProyectil);
    }
}
