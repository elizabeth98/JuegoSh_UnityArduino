using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class puntaje : MonoBehaviour
{
    public static int elim;
    Text text;
    public Text winGame;
    // Start is called before the first frame update
    private void Awake() {
        text = GetComponent<Text>();
        elim = 0;
    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "PUNTOS:" + elim;
        if (elim >= 8)
        {

            winGame.text = "¡GANASTE!";
            SceneManager.LoadScene(1);


        }
    }
}
