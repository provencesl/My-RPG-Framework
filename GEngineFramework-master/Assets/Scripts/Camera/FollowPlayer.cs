/*
 * GEngine Framework for Unity By Garson(https://github.com/garsonlab)
 * -------------------------------------------------------------------
 * FileName: FollowPlayer
 * Date    : 2019/08/10
 * Version : v1.0
 * Describe: 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    private Transform player;

    private Vector3 offset;

    private bool isRotating = false;


    public float distance = 0;
    public float scrollSpeed = 10;
    public float rotateSpeed = 2;


	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("player").transform;
        transform.LookAt(player.position);

        //
        offset = transform.position - player.position;

		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = offset + player.position;

	}


    private void ScrollView()
    {
        //点到原点的距离
        distance = offset.magnitude;
        distance += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        distance = Mathf.Clamp(distance,2,18);

        offset = offset.normalized * distance;

    }

    private void RotateView()
    {
        //右键控制旋转
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;

        }
        if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
        }

        if (isRotating)
        {

        }


    }


}
