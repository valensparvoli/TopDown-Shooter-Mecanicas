using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobinaScript : MonoBehaviour
{
    public static int vidaBobina;
    
    public GameObject escudo;
    

    float rNaranja = 255f;
    float gNaranja = 112f;
    float bNaranja = 0;

    void Start()
    {
        vidaBobina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaBobina <= 75)
        {
            GetComponent<SpriteRenderer>().color = new Color(rNaranja, gNaranja, bNaranja);
        }
        if (vidaBobina <= 25)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (vidaBobina == 0)
        {
            Destroy(this.gameObject);
            Destroy(escudo);
        }

        
   
    }
}
