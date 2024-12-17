using TMPro;
using UnityEngine;
using Unity.Netcode;
using Unity.Collections;

public class BillboardText : NetworkBehaviour
{
    private RectTransform rectTransform;
    [SerializeField] private TMP_Text NameTag;
    public string Name = "babaroga";

    private NetworkVariable<FixedString32Bytes> PlayerName = new NetworkVariable<FixedString32Bytes>(new FixedString32Bytes(""),NetworkVariableReadPermission.Everyone,NetworkVariableWritePermission.Owner);

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        PlayerName.Value = new FixedString32Bytes(Name);
        if (IsOwner)
        {
            gameObject.active = false;
        }
    }

    void Update()
    {
        if (!IsOwner)
        {
            Camera activeCamera = Camera.main;
            if (activeCamera != null && rectTransform != null)
            {
                Vector3 directionToCamera = rectTransform.position - activeCamera.transform.position;
                rectTransform.rotation = Quaternion.LookRotation(directionToCamera, Vector3.up);

                // Update the NameTag text
                NameTag.text = PlayerName.Value.ToString();
            }
        }
    }
}
