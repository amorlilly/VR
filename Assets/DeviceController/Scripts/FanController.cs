using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WebSocketClient))]
public class FanController : MonoBehaviour
{
    private WebSocketClient _webSocket;

    private bool _initialized = false;

    public KeyCode ResetKey = KeyCode.Escape;

    // Use this for initialization
    void Start()
    {
        _webSocket = GetComponent<WebSocketClient>();
        if (_webSocket != null) StartCoroutine(Connect());
    }

    public WebSocketClient GetWebSocketClient()
    {
        return _webSocket;
    }

    /// <summary>
    /// Websocketを監視して、接続状態になったらEMSパッドを電源オフにする
    /// </summary>
    /// <returns></returns>
    IEnumerator Connect()
    {
        while (true)
        {
            Debug.Log("wait for connecting");
            yield return new WaitForSeconds(0.5f); // すぐには繋がらないので少しだけ待つ

            if (_webSocket.IsConnected)
            {
                Debug.Log("EMSPad Initialized");
                Reset();
                _initialized = true;
                break;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(ResetKey))
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PowerOn();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            PowerOff();
        }
    }

    public void PowerOn()
    {
        Debug.Log("power on");
        if (_webSocket.IsConnected)
            _webSocket.Send("ON");
    }

    public void PowerOff()
    {
        Debug.Log("power off");
        if (_webSocket.IsConnected)
            _webSocket.Send("OFF");
    }

    public void Reset()
    {
        if (_webSocket.IsConnected)
            PowerOff();
    }
}