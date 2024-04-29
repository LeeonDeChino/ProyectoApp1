using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Escenario escenario;
    public int[] secuencia;
    public int position;
    public Canvas gameOverCanvas;
    public Canvas secuenciaCanvas;
    public TextMeshProUGUI secuenciaText;

    private void Start()
    {
        gameOverCanvas.enabled = false;
        secuenciaCanvas.enabled = false;
        SecuenciaRandom();
    }

    void SecuenciaRandom()
    {
        secuencia = new int[4];
        bool[] used = new bool[5];

        for (int i = 0; i < 4; i++)
        {
            int numRandom = 0;
            do
            {
                numRandom = Random.Range(1, 5);
            } while (used[numRandom]);

            secuencia[i] = numRandom;
            used[numRandom] = true;
        }

        escenario.StartLevel(secuencia);
        secuenciaCanvas.enabled = true;
        secuenciaText.text = (secuencia[0].ToString()+ secuencia[1].ToString()+ secuencia[2].ToString()+ secuencia[3].ToString());
        position = 0;
    }

    public void SetSecuencia(Caja caja)
    {

        if (caja.idCaja == secuencia[position])
        {
            Debug.Log("Correcto");
            position++;
            caja.DesactivarCaja();

            if(position >= secuencia.Length) {
                Debug.Log("Juego terminado");
                gameOverCanvas.enabled = true;
                secuenciaCanvas.enabled = false;

            }
        }
    }

}
