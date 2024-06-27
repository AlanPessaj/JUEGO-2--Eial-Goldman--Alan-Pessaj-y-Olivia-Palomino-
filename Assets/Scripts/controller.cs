using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        int random = Random.Range(0, 16);
        return Productos[random];
    }
    public static GameObject selected1;
    public static GameObject selected2;
    public MoveObject moveController;
    public Text txtMoney;
    void Inicio()
    {
        selected1 = Selector();
        selected2 = Selector();
        moveController.moveObject();
        txtMoney.text = Random.Range(20, 91).ToString();
    }

    void btnAlcanza()
    {
        if(txtMoney.text.ToInt() == (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Pass();
        }
        else
        {
            Repeat();
        }        
    }
    void btnSobra()
    {
        if(txtMoney.text.ToInt() > (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Pass();
        }
        else
        {
            Repeat();
        }
    }
    void btnFalta()
    {
        if(txtMoney.text.ToInt() < (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Pass();
        }
        else
        {
            Repeat();
        }    
    }
    public GameObject clon1 = moveController.object1;
    public GameObject clon2 = moveController.object2;
    void Pass()
    {
        
    }
    void Repeat()
    {

    }
}
