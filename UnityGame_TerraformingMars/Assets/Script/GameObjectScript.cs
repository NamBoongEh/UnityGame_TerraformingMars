using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // ESC �Է� �� ���� ����
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
