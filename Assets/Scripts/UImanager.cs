using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]private Button startServerButton;
    [SerializeField]private Button startHostButton;   
    [SerializeField]private Button startClientButton;
    [SerializeField]private TextMeshProUGUI PlayersInGameText;
    private void Awake() 
    {
        Cursor.visible = true;
    }
    
    
    void Start()
    {
        
    }

    
    
    void Update()
    {
        //PlayersInGameText.text = $"Players in ganme 0";
    }

    public void StartHost()
    {
        if(NetworkManager.Singleton.StartHost())
        {
            Debug.Log($"Host is online!");
        }
        else
        {
            Debug.Log($"Host could not be started!");
        }
    }
    public void StartServer()
    {
        if(NetworkManager.Singleton.StartServer())
        {
            Debug.Log($"Server is online!");
        }
        else
        {
            Debug.Log($"Server could not be started!");
        }
    }
    public void StartClient()
    {
        if(NetworkManager.Singleton.StartClient())
        {
            Debug.Log($"Client is online!");
        }
        else
        {
            Debug.Log($"Client could not be started!");
        }
    }
}
