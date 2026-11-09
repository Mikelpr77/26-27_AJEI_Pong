using UnityEngine;

public class limitedemovimiento : MonoBehaviour
{
    public float limiteMax = 4;
    public float limiteMin = -4;

    //tart is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > limiteMax)
        {
            Debug.Log("Me he pasado por encima del limite maximo");
        }
    }
}
