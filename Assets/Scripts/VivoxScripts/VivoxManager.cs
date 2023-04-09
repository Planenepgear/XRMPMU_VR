using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using VivoxUnity;

public class VivoxManager : MonoBehaviour
{
    VivoxVoiceManager vivox;
    Client client = new Client();

    [Header("Login UI")]
    [SerializeField] TMP_InputField input_Username;
    [SerializeField] TMP_InputField input_ChannelName;
    [SerializeField] TextMeshProUGUI txt_Username;
    [SerializeField] TextMeshProUGUI txt_ChanelName;

    void Awake()
    {
        vivox = VivoxVoiceManager.Instance;
        client.Uninitialize();
        client.Initialize();
        vivox.OnUserLoggedInEvent += LoggedIn;
    }

    private void OnApplicationQuit()
    {
        if(vivox.LoginState == LoginState.LoggedIn)
        {
            vivox.Logout();
        }
        client.Uninitialize();
    }


    public void Login()
    {
        if (!string.IsNullOrEmpty(input_Username.text))
        {
            vivox.Login(input_Username.text);
        }
    }


    private void LoggedIn()
    {
        txt_Username.text = vivox.LoginSession.LoginSessionId.DisplayName;
    }

    public void Logout()
    {
        if (vivox.LoginState == LoginState.LoggedIn)
        {
            vivox.Logout();
        }
    }

    public void JoinChannel()
    {
        if (!string.IsNullOrEmpty(input_ChannelName.text))
        {
            vivox.JoinChannel(input_ChannelName.text, ChannelType.NonPositional, VivoxVoiceManager.ChatCapability.AudioOnly);
            txt_ChanelName.text = input_ChannelName.text;
        }
    }
}
