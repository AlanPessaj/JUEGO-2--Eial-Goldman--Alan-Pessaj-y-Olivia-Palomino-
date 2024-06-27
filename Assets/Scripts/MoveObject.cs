using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 position1;
    public Vector3 position2;

    Vector3 ogPosition1;
    Vector3 ogPosition2;
    public controller myController;

    public GameObject object1;
    public GameObject object2;
    bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float i = 0;
    void Update()
    {
        if (i<1 && move)
        {
            i+= 1f * Time.deltaTime;
            Vector3 temp1;
            Vector3 temp2;
            temp1 = new Vector3(Mathf.Lerp(ogPosition1.x, position1.x, i), 0, 0);
            temp2 = new Vector3(Mathf.Lerp(ogPosition2.x, position2.x, i), 0, 0);

            temp1 = new Vector3(temp1.x, Mathf.Lerp(ogPosition1.y, position1.y, i), 0);
            temp2 = new Vector3(temp2.x, Mathf.Lerp(ogPosition2.y, position2.y, i), 0);

            temp1 = new Vector3(temp1.x, temp1.y, Mathf.Lerp(ogPosition1.z, position1.z, i));
            temp2 = new Vector3(temp2.x, temp2.y, Mathf.Lerp(ogPosition2.z, position2.z, i));

            object1.transform.position = temp1;
            object2.transform.position = temp2;
        }
        else
        {
            move = false;
            i = 0;
        }
    }

    public void moveObject()
    {
        object1 = Instantiate(controller.selected1);
        object2 = Instantiate(controller.selected2);
        ogPosition1 = object1.transform.position;
        ogPosition2 = object2.transform.position;
        move = true;
    }
}
