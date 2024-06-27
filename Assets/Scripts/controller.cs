using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public GameObject won;
    public GameObject lost;
    public GameObject endPanel;
    public GameObject[] Productos;
    public GameObject clon1;
    public GameObject clon2;

    // Start is called before the first frame update
    void Start()
    {
        clon1 = moveController.object1;
        clon2 = moveController.object2;
        Inicio();
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
        if(int.Parse(txtMoney.text) == (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Won();
        }
        else
        {
            Lost();
        }        
    }
    void btnSobra()
    {
        if(int.Parse(txtMoney.text) > (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Won();
        }
        else
        {
            Lost();
        }
    }
    void btnFalta()
    {
        if(int.Parse(txtMoney.text) < (selected1.GetComponent<Producto>().Precio)+(selected2.GetComponent<Producto>().Precio))
        {
            Won();
        }
        else
        {
            Lost();
        }    
    }
    void Won()
    {
        Destroy(clon1);
        Destroy(clon2);
        endPanel.SetActive(true);
        won.SetActive(true);
    }
    void Lost()
    {
        endPanel.SetActive(true);
        lost.SetActive(true);
    }
    public void Exit()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Retry()
    {
        endPanel.SetActive(false);
        lost.SetActive(false);
    }
}
