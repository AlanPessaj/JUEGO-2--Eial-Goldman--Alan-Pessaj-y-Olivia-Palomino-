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

    GameObject object1;
    GameObject object2;
    // Start is called before the first frame update
    void Start()
    {
        object1 = Instantiate(controller.selected1);
        object2 = Instantiate(controller.selected2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveObject()
    {
        ogPosition1 = object1.transform.position;
        ogPosition2 = object2.transform.position;
        for (float i = 0; i < 1; i+= 0.1f)
        {
            Vector3 temp1;
            Vector3 temp2;
            temp1 = new Vector3(Mathf.Lerp(ogPosition1.x, position1.x, i), 0, 0);
            temp2 = new Vector3(Mathf.Lerp(ogPosition2.x, position2.x, i), 0, 0);

            temp1 = new Vector3(temp1.x, Mathf.Lerp(ogPosition1.y, position1.y, i), 0);
            temp2 = new Vector3(temp2.x, Mathf.Lerp(ogPosition2.y, position2.y, i), 0);

            temp1 = new Vector3(temp1.x, temp1.y, Mathf.Lerp(ogPosition1.x, position1.x, i));
            temp2 = new Vector3(temp2.x, temp2.y, Mathf.Lerp(ogPosition2.x, position2.x, i));
        }
    }
}
