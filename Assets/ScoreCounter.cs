using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    private int puntaje = 0;
    public int GetPuntaje()
    {
        return puntaje;
    }

    public void SumarPuntos(int puntos)
    {
        puntaje += puntos;
        actualizarUI();
        FindObjectOfType<FinalScore>().Refrescar();
    }

    void actualizarUI()
    {
        textoPuntaje.text = "Puntaje: " + puntaje;
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
