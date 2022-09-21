using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Vector3 kekanan;
    public Vector3 kekiri;
    public Vector3 keatas;
    public Vector3 kebawah;
    public Vector3 mundur;
    public Vector3 maju;
    public int aksi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(aksi){
            case 0:
                transform.position = transform.position + (kekanan * 2f * Time.deltaTime);
                break;
            case 1:
                transform.position = transform.position + (kekiri * 2f * Time.deltaTime);
                break;            
            case 2:
                transform.position = transform.position + (keatas * 2f * Time.deltaTime);
                break;
            case 3:
                transform.position = transform.position + (kebawah * 2f * Time.deltaTime);
                break;
            case 4:
                transform.position = transform.position + (maju * 2f * Time.deltaTime);
                break;
            case 5:
                transform.position = transform.position + (mundur * 2f * Time.deltaTime);
                break;

        }
    }
}
