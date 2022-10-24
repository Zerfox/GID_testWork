
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    private Ball _ball;
    private Camera _camera;
   
    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
        //_camera = GetComponent();
    }

    private  void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                sendTheBallCoordinates(mousePos);
                Debug.Log(mousePos.x);
            }
        }
    }
    private void sendTheBallCoordinates(Vector3 mousePos)
    {
        _ball.saveCoordinates(mousePos);


    }
}