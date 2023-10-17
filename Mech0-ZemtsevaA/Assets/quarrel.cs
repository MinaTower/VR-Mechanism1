using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class quarrel : MonoBehaviour
{
    // Start is called before the first frame update0
    public int counter = 18;
    public Text cou;
    public GameObject Cube;
    public float Speed = 5f;
    void Start() {
        Debug.Log('1');
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void OnCollisionEnter(Collision collider)
    {
        counter -= 1;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Speed * Time.deltaTime);
        }
        cou.text = "Start";
        cou.text = counter.ToString();
    }
    


}
