using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Caja : MonoBehaviour
{
    private int idCaja;
    private TextMeshPro idText;

    public void AsignarID(int idP)
    {
        idCaja = idP;
        idText = GetComponentInChildren<TextMeshPro>();
        idText.text = idP.ToString();
    }
}
