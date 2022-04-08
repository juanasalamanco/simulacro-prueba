using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej02 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    public int dinero;


    // Start is called before the first frame update
    void Start()
    {
        int precioT;
        precioT = precio1 + precio2 + precio3;

        if(precioT == dinero)
        {
            Debug.Log("El monto a pagar es el mismo que el dinero que tenes");
        }
        else if(precioT > dinero)
        {
            int dineroFalta = precioT - dinero;
            Debug.Log("No te alcanza el dinero, te faltan $" +dineroFalta);
        }
        else if(precioT < dinero)
        {
            int dineroSobra = dinero - precioT;
            Debug.Log("Te alcanza para pagar y te sobran $" +dineroSobra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
