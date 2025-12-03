using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolaProyectiles : MonoBehaviour
{
    public Transform firePoint; // punto desde donde sale el proyectil (la punta de la pistola)
    public GameObject proyectilPrefab; // prefab de la esfera
    private RecogerArma recogerArmaScript;

    [SerializeField] float fuerzaProyectil; //fuerza con la que sale el proyectil

    [SerializeField] ShotCounter shotCounter;
    [SerializeField] ScoreCounter scoreCounter;

    void Start()
    {
        recogerArmaScript = FindObjectOfType<RecogerArma>();
    }

    void Update()
    {
        if (!recogerArmaScript.tengoPistola) return;

        if (Input.GetKeyDown(KeyCode.K))
        {
            Disparar();
        }
    }


    void Disparar()
    {
        GameObject bala = Instantiate(proyectilPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        if (rb != null)
            rb.AddForce(firePoint.forward * fuerzaProyectil);

        var proyectilScript = bala.GetComponent<proyectil>();
        if (proyectilScript != null)
            proyectilScript.scoreCounter = scoreCounter;
        else
            Debug.LogWarning("El prefab no tiene el script 'proyectil' adjuntado.");

        // Sumar un disparo
        if (shotCounter != null)
            shotCounter.SumarDisparo();
    }
}
