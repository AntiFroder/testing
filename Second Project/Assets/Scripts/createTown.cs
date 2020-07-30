using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTown : MonoBehaviour
{
    public GameObject Town;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 MosPos = Input.mousePosition;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(MosPos);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(Town, new Vector3(MosPos.x, MosPos.y, 0), Quaternion.identity);
            }
        }
    }
}
