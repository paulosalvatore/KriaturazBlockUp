using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
	public static Controlador instancia;

	public CinemachineVirtualCamera camera1;
	public CinemachineVirtualCamera camera2;

	private void Awake()
	{
		instancia = this;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
