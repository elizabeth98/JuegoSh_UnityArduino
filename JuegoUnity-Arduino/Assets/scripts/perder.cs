using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class perder : MonoBehaviour
    

{

    public GameObject textGameOver;
    public GameObject button;
    public GameObject panel;



    public GameObject efectoExplosion;
    public AudioClip efectoSonido = null;
    public float volumen = 10;
    protected Transform poscicion = null;


    void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.tag == ("enemy"))
        {
            Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            poscicion = transform;
            AudioSource.PlayClipAtPoint(efectoSonido, poscicion.position, volumen);
            Destroy(gameObject);
            textGameOver.SetActive(true);
            button.SetActive(true);
            panel.SetActive(true);
            Debug.Log("perdi");

        }




    }
}
