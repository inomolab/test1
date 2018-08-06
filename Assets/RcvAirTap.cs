﻿using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RcvAirTap : MonoBehaviour, IInputClickHandler
{

    //Cube Prefab を扱う変数
    public GameObject original;

    //AirTapされたときに呼び出される関数
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //throw new NotImplementedException();

        //Cube Prefab の情報を用いて実体化
        GameObject cube = GameObject.Instantiate(original);
        //自分からみて前方1.2mの位置を空間内の位置に変換
        cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);
    }

    // Start関数は初期化のために一度だけ実行される
    void Start()
    {
        //AirTap の通知が gameObject に渡るように設定
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    // Update は毎フレーム毎実行される
    void Update()
    {
    }
}