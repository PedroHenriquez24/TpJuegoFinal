using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShotCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoDisparos;   // Referencia al texto "Disparos: "
    private int disparos = 0;              // Contador interno

    // Llamá a este método cada vez que la pistola dispara
    public int GetDisparos()
    {
        return disparos;
    }

    public void SumarDisparo()
    {
        disparos++;
        actualizarUI();
        FindObjectOfType<FinalScore>().Refrescar();
    }

    void actualizarUI()
    {
        textoDisparos.text = "Disparos: " + disparos;
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
