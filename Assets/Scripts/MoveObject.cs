using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Vector3 position1;
    Vector3 position2;

    Vector3 ogPosition1;
    Vector3 ogPosition2;
    public controller myController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveObject()
    {
        ogPosition1 = controller.selected1.transform.position;
        ogPosition2 = controller.selected2.transform.position;
        for (float i = 0; i < 1; i+= 0.1f)
        {
            controller.selected1.transform.position = Mathf.Lerp(ogPosition1, position1, i);
            controller.selected2.transform.position = Mathf.Lerp(-ogPosition2, position2, i);
        }
    }
}
