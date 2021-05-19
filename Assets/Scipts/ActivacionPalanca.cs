using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivacionPalanca : MonoBehaviour
{
    public GameObject palanca;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            palanca.SetActive(true);
            Destroy(gameObject);
        }
    }
}
