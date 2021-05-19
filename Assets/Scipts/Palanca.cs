using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    public GameObject puertaBoss;
    public GameObject puertaPowerUp;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            puertaBoss.SetActive(false);
            puertaPowerUp.SetActive(false);
            Destroy(gameObject);
        }
    }
}
