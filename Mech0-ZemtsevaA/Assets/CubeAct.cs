using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CubeAct : MonoBehaviour
{
    public GameObject Button;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log('1');
    }

    // Update is called once per frame
    /*void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.Mouse0))//Input.GetKey(KeyCode.Mouse0)
        //{
        //    if (Cube.activeInHierarchy)
        //    {
        //        Cube.SetActive(false);
        //    }
        //    else
        //    {
        //        Cube.SetActive(true);
        //    }
        //};
    }*/
    public void OnClick()
    {
        Debug.Log('2');
        if (Cube.activeInHierarchy)
        {
            Cube.SetActive(false);
        }
        else
        {
            Cube.SetActive(true);
        }
    }
}
