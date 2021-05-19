using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Bobina"))
        {
            BobinaScript.vidaBobina -= 25;
        }

        if (collision.collider.CompareTag("Boss"))
        {
            BossScript.vidaBoss -= 10;
        }

        if (collision.collider.CompareTag("Enemy"))
        {
            EnemyDamage.vidaEenemy -= 10;
        }
    }
}
