using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Caja : MonoBehaviour
{
    public int idCaja;
    private TextMeshPro idText;
    public GameManager gameManager;

    public void AsignarID(int idP)
    {
        idCaja = idP;
        idText = GetComponentInChildren<TextMeshPro>();
        idText.text = idP.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log(idCaja);
            gameManager.SetSecuencia(this);   

        }
    }

    public void DesactivarCaja()
    {
        gameObject.SetActive(false);
    }
}
