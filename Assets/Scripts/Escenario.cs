using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario : MonoBehaviour
{
    public Caja[] cajas;

    public void StartLevel(int[] sec)
    {
        for(int i = 0; i < sec.Length; i++) 
        {
            cajas[i].AsignarID(sec[i]); 
        }
    }
}
