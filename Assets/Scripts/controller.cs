using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject[] Productos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject Selector()
    {
        int random = Random.Range(0, 19);
        return Productos[random];
    }
    public static GameObject selected1;
    public static GameObject selected2;
    public MoveObject moveController;
    void Inicio()
    {
        selected1 = Selector();
        selected2 = Selector();
        moveController.moveObject();
    }

    void ReciveButton()
    {
        /*if(Convert.ToInt32(Texto) == (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio)){
            Pass();
        }
        else
        {
            Repeat();
        }*/
    }

    void Pass()
    {//Eial UI

    }
    void Repeat()
    {//Eial UI

    }
}
