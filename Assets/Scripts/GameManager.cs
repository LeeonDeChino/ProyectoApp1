using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Escenario escenario;
    private int[] secuencia;

    private void Start()
    {
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

    }

}
