using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI textoPromedio;   // El bloque de texto del promedio
    public ScoreCounter scoreCounter;       // Referencia al puntaje
    public ShotCounter shotCounter;         // Referencia a los disparos

    void UpdatePromedio()
    {
        int puntos = scoreCounter.GetPuntaje();
        int disparos = shotCounter.GetDisparos();

        if (disparos == 0)
        {
            textoPromedio.text = "Promedio: 0";
        }
        else
        {
            float promedio = (float)puntos / disparos;
            textoPromedio.text = "Promedio: " + promedio.ToString("0.00");
        }
    }

    // Llamado desde otros scripts
    public void Refrescar()
    {
        UpdatePromedio();
    }
}
