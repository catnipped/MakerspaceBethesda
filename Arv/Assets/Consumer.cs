using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int ConsumableItem[] item;

    public int selectedIndex;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item[selectedIndex].consume();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && selectedIndex != 0)
        {
            slelectedIndex--;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selectedIndex < item.Length - 1)

            else
                selectedIndex = 0;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if ( item[selectedIndex] != null)
            {
                Debug.Log(item[selectedIndex])
            }
        }
    }
}
