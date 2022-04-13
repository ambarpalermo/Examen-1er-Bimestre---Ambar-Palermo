using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tema5 : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;

    public int precio1;
    public int precio2;
    public int precio3;

    public int unidades1;
    public int unidades2;
    public int unidades3;

    

    // Start is called before the first frame update
    void Start()
    {
        int descuento1= precio1 % 5;
        int descuento2= precio2 % 5;
        int descuento3= precio3 % 5;

        int TotalLimpio = precio1 + precio2 + precio3;
        int DescuentosAplicados = descuento1 + descuento2 + descuento3;
        int TotalDescuentos= TotalLimpio + DescuentosAplicados; 

        if (precio1 < 1 || precio2 < 1 || precio3 < 1)
        {
            Debug.Log("El precio no puede ser menor a 1");
        }
        else if (unidades1 < 1 || unidades2 < 1 || unidades3 < 1)
        {
            Debug.Log("Faltan ingresar unidades");
        }
       else if(unidades1>3)
        {
            descuento1 = precio1 % 5;
            Debug.Log("");
        }

        else if(unidades2>3)
        {
            descuento2 = precio2 % 5;
            Debug.Log("");
        }
        else if (unidades3>3)
        {
            descuento3 = precio3 % 5;
            Debug.Log("");
        }
        else
        {
            Debug.Log("el total sin descuentos es " + TotalLimpio + "el total de descuentos es " + DescuentosAplicados + " el total es " + TotalDescuentos);
        }

        }

    
        
       
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
