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
        // ESC 입력 시 게임 종료
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
