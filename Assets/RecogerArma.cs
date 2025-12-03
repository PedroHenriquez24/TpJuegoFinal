using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerArma : MonoBehaviour
{
    public float distanciaRecoger = 3f;
    public LayerMask recogerLayer;      // Capa "Pickup" para la pistola en el piso
    public Transform mano;        // Donde se equipa la pistola (mano/cámara)
    public pistolaProyectiles scriptPistola;  // El script de disparos
    public bool tengoPistola = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!tengoPistola)
            BuscarArma();
    }
    void BuscarArma()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distanciaRecoger, recogerLayer))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EquiparArma(hit.collider.gameObject);
            }
        }
    }
    void EquiparArma(GameObject gun)
    {
        tengoPistola = true;

        //desativar collider para que no choque con el jugador
        Collider col = gun.GetComponent<Collider>();
        if (col != null)
            col.enabled = false;

        //con esto pongo el arma en la mano
        gun.transform.SetParent(mano);
        gun.transform.localPosition = Vector3.zero;
        gun.transform.localRotation = Quaternion.identity;
    }
}
