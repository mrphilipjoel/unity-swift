#if !UNITY_EDITOR && UNITY_IOS
using System.Runtime.InteropServices;
#endif
using UnityEngine;
using UnityEngine.UI;

public class WeatherTest : MonoBehaviour
{
    public Text TempText = null;
    public Text CondText = null;

    private float _update;
    private bool _called = false;

#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void cGetWeather();

#endif


    private void Update()
    {
        _update += Time.deltaTime;
        if (_update > 5.0f && !_called)
        {
            _update = 0.0f;
            _called = true;

#if UNITY_IOS && !UNITY_EDITOR
            cGetWeather();
#endif
        }
    }

    private void OnMessageReceived(string message)
    {
        TempText.text = message;
    }
}
