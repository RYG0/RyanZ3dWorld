/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cinemachine;

public class Player : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera PlayerFollowCamera;
    [SerializeField] CinemachineVirtualCamera PlayerUpperCamera;

    private void OnEnable()
    {
        CameraSwitcher.Register(PlayerFollowCamera);
        CameraSwitcher.Register(PlayerUpperCamera);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(PlayerFollowCamera);
        CameraSwitcher.Unregister(PlayerUpperCamera);
    }
    private void Update()
    {
        if (Input.GetKeyDown(Keycode.space))
        {
            //switch
        }
    }
}
*/