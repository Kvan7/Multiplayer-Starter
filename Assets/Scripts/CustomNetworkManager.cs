using Mirror;
using UnityEngine;
using Valve.VR;

public class CustomNetworkManager : NetworkManager
{
	// Override the ServerChangeScene method to use SteamVR_LoadLevel
	public override void ServerChangeScene(string newSceneName)
	{
		// Your existing server-side scene change logic here
		// ...

		// Use SteamVR's scene loading mechanism
		LoadSceneWithSteamVR(newSceneName);
	}

	// Override OnClientConnect to handle client-side scene changes
	public override void OnClientConnect()
	{
		base.OnClientConnect();

		// Optionally, load a scene using SteamVR when the client connects
		// if needed, based on your game's logic
	}

	// Override OnClientSceneChanged to handle actions after a scene has been changed
	public override void OnClientSceneChanged()
	{
		base.OnClientSceneChanged();

		// Handle any post-scene-change logic here
		// For example, you might want to activate certain game objects only after the scene has been loaded
	}

	// A method to encapsulate SteamVR's scene loading, to be called from ServerChangeScene or elsewhere
	private void LoadSceneWithSteamVR(string sceneName)
	{
		if (!string.IsNullOrEmpty(sceneName))
		{
			SteamVR_LoadLevel.Begin(sceneName);
		}
		else
		{
			Debug.LogError("Attempted to load a scene with an empty or null name using SteamVR.");
		}
	}

	// Additional custom logic as needed for your game...
}
