using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

public class WebSocketClient : MonoBehaviour
{
    public string Hostname = "localhost";
    public int Port = 10001;

    public KeyCode ResetKey = KeyCode.F1;

    private WebSocket _websocket;

    public bool AutoConnect = false;

    /**
     * 接続中か
     */
    public bool IsConnected = false;

    public bool Reconnecting = false;

    public int ReconnectDuration = 1;

    // Use this for initialization
    void Start()
    {
        _websocket = new WebSocket($"ws://{Hostname}:{Port}");

        _websocket.OnOpen += (sender, e) =>
        {
            IsConnected = true;
            Debug.Log($"[{gameObject.name}] WebSocket Open");
        };

        _websocket.OnClose += (sender, e) =>
        {
            IsConnected = false;
            Debug.Log("[" + gameObject.name + "] WebSocket Close");
        };

        _websocket.OnError += (sender, e) =>
        {
            Debug.Log("[" + gameObject.name + "] WebSocket Error Message: " + e.Message);
        };

        if (AutoConnect)
            _websocket.Connect();
    }

    void OnDestroy()
    {
        if (_websocket != null)
        {
            // 終了処理
            _websocket.Close();
            _websocket = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 指定したキーが押されたら再接続してみる
        if (Input.GetKeyDown(ResetKey))
        {
            _websocket.Close();
            _websocket.Connect();
        }

        // 接続が切れていたら再接続を試みる
        if (AutoConnect && !IsConnected && !Reconnecting)
        {
            Reconnecting = true;
            StartCoroutine(ReConnect());
        }
    }

    /**
     * 再接続する
     */
    IEnumerator ReConnect()
    {
        yield return new WaitForSeconds(ReconnectDuration); // ５秒間待つ

        if (!IsConnected)
            _websocket.Connect();
        
        Reconnecting = false;
    }

    /**
	 * データを送信する
	 */
    public void Send(string data)
    {
        if (IsConnected)
        {
            Debug.Log("send: " + data);
            _websocket.Send(data);
        }
    }
}