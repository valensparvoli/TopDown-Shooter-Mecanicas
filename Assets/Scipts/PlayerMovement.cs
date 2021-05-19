using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public static int Vida = 100;
    public static float Speed = 5f;
    public Rigidbody2D rb;
    
    public Camera cam;

    public Text UiVida;

    Vector2 movement;
    Vector2 mousePos;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Vida <= 0)
        {
            Perdiste();
        }

        UiVida.text = "Vida:" + Vida.ToString();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePos - rb.position;
        float Angle = Mathf.Atan2(lookDirection.y, lookDirection.x)*Mathf.Rad2Deg-90f;
        rb.rotation = Angle;

    }

    public void Perdiste()
    {
        SceneManager.LoadScene("LoseScene");
    }


}
