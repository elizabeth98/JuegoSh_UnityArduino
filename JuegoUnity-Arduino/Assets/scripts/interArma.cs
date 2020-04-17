using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class interArma : MonoBehaviour
{
    public Rigidbody balaprefab;
    private int dir;
    private int disp;
    public Transform lanzador;
    public float velDisp;
    private float inicioDisparar;
    public float tiempoDisparo;
   private Vector3 temp = new Vector3(0.5f, 0, 0);

    SerialPort puerto = new SerialPort("COM3", 9600);

    // Start is called before the first frame update
    void Start()
    {
        puerto.Open();
        puerto.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (puerto.IsOpen)
        {
            try
            {
               mover(puerto.ReadLine());


            }

            catch (System.Exception)
            {
            }
        }

    

  


    }
void mover(string datoArduino)
{

    string[] datosArray = datoArduino.Split(char.Parse(","));

    if (datosArray.Length == 2)
    {
        dir = int.Parse(datosArray[0]);
        disp = int.Parse(datosArray[1]);



    }

    if (dir >= 500) {

        transform.Translate(0.5f, 0, 0);
        // temp = new Vector3(0.5f, 0, 0);
        //transform.position += temp;


    }

    if (dir <= 500)
    {
        transform.Translate(-0.5f, 0, 0);

    }


    if (disp == 1 && Time.time > inicioDisparar) {

        inicioDisparar = Time.time + tiempoDisparo;
        Rigidbody balaIns;

        balaIns = Instantiate(balaprefab, lanzador.position, Quaternion.identity) as Rigidbody;
        balaIns.AddForce(lanzador.forward * 100 * velDisp);
    }



}
}
    

