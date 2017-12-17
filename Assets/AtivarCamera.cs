using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarCamera : MonoBehaviour
{
	public CinemachineVirtualCameraBase ativarCamera;
	public CinemachinePathBase.PositionUnits unidadesDePosicionamento = CinemachinePathBase.PositionUnits.Distance;
	//public float velocidade = 5f;

	private CinemachineBrain brain;

	private void Start()
	{
		brain = Camera.main.GetComponent<CinemachineBrain>();
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player") && ativarCamera)
		{
			if (brain.ActiveVirtualCamera.Name != ativarCamera.Name)
			{
				brain.ActiveVirtualCamera.VirtualCameraGameObject.SetActive(false);

				ativarCamera.VirtualCameraGameObject.SetActive(false);
				ativarCamera.VirtualCameraGameObject.SetActive(true);
			}
		}
	}
}
