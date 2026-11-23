using UnityEngine;
using TMPro; 

public class GestordePuntuacin : MonoBehaviour
{
    public int puntuacionA;
    public int puntuacionB;

    public TMP_Text puntuacionAtexto;
    public TMP_Text puntuacionBtexto;

    //int: numero entero
    //float: numero decimal
    //bool: verdadero/falso
    //string: texto o casdena de caracteres
    //Vector
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionAtexto.text = puntuacionA.ToString();
        puntuacionBtexto.text = puntuacionB.ToString();

        if (puntuacionA > 10)
        {
            Debug.Log("Jugador A ha ganado");
        }
        if (puntuacionB > 10)
        {
            Debug.Log("Jugador b ha ganado");
        }
    }
}