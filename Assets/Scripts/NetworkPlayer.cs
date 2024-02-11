using UnityEngine;
using Valve.VR;
using Mirror;

public class NetworkPlayer : NetworkBehaviour
{
	public Transform head;
	public Transform leftHand;
	public Transform rightHand;

	private SteamVR_Behaviour_Pose leftHandPose;
	private SteamVR_Behaviour_Pose rightHandPose;

	void Start()
	{

		if (isLocalPlayer)
		{
			// Find SteamVR_Behaviour_Pose components dynamically at runtime
			// This assumes you have SteamVR_Behaviour_Pose components attached to your controller objects
			SteamVR_Behaviour_Pose[] poses = FindObjectsOfType<SteamVR_Behaviour_Pose>();
			foreach (var pose in poses)
			{
				if (pose.inputSource == SteamVR_Input_Sources.LeftHand)
					leftHandPose = pose;
				else if (pose.inputSource == SteamVR_Input_Sources.RightHand)
					rightHandPose = pose;

			}
		}
	}

	void Update()
	{
		if (isLocalPlayer)
		{
			// Update head position and rotation
			head.position = Camera.main.transform.position;
			head.rotation = Camera.main.transform.rotation;

			// Update hand positions and rotations if the poses are valid
			if (leftHandPose != null)
			{
				leftHand.position = leftHandPose.transform.position;
				leftHand.rotation = leftHandPose.transform.rotation;
			}
			if (rightHandPose != null)
			{
				rightHand.position = rightHandPose.transform.position;
				rightHand.rotation = rightHandPose.transform.rotation;
			}

			leftHand.gameObject.SetActive(false);
			rightHand.gameObject.SetActive(false);
		}
	}
}
