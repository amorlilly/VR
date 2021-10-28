using System.Collections;
using UnityEngine;

/**
 * EMSPadに制御信号を送信する
 * 送信コマンド
 * INC [数値]: 数値だけON/INCボタンを押す動作
 * DEC [数値]: 数値だけOFF/DECボタンを押す動作
 * OFF: DECを規定回数以上送り、電源オフ状態までにする
 */
[RequireComponent(typeof(WebSocketClient))]
public class EmsPadController : MonoBehaviour
{
    public const int MaxStrength = 10;

    public int CurrentStrength = 0;

    private int _strength = 0;
    
    public int Strength
    {
        // 指定した強度に設定する 0～10の値。０は電源オフ
        set => _strength = Mathf.Clamp(value, 0, MaxStrength);
        get => _strength;
    } // 強度

    private WebSocketClient _webSocket;

    private bool _initialized = false;

    private float _sendTime = 0;
    public float SendDuration = 0.5f;

    public KeyCode ResetKey = KeyCode.Alpha0;

    // Use this for initialization
    void Start()
    {
        _webSocket = GetComponent<WebSocketClient>();
        Strength = 0;
        CurrentStrength = 0;
        if (_webSocket != null) StartCoroutine(InitEmsPad());
    }

    public WebSocketClient GetWebSocketClient()
    {
        return _webSocket;
    }

    /// <summary>
    /// Websocketを監視して、接続状態になったらEMSパッドを電源オフにする
    /// </summary>
    /// <returns></returns>
    IEnumerator InitEmsPad()
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
        if (_initialized && (Time.time - _sendTime > SendDuration))
        {
            SendCommand();
        }

        if (Input.GetKeyDown(ResetKey))
        {
            Reset();
        }
    }

    public void SendCommand()
    {
        var diff = Strength - CurrentStrength;
        if (diff == 0) return; // 現在の強度と設定したい強度が同じなら何もしない

        _sendTime = Time.time;

        if (Strength == 0)
        {
            Reset();
            return;
        }

        _webSocket.Send(diff > 0 ? $"INC {diff}" : $"DEC {-diff}");

        CurrentStrength = Strength;
    }

    public void Reset()
    {
        _sendTime = Time.time;
        _webSocket?.Send("OFF");
        CurrentStrength = Strength = 0;
    }
}