using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour
{
    public int value = 1;

    private int contador;

    private void OnCollisionEnter(Collision collision)
    {
       
        Destroy(gameObject);
        if (collision.gameObject.tag == ("bala")) {

            puntaje.elim += value;
            
        }
        
        
        

    }

   

}
