# Multiplayer-Starter

Sample starter template for basic multiplayer game with unity.

## Getting Started

1. Clone the repository
2. Open the project in Unity
3. Open the `MenuLobby` scene
4. Build the project
5. Add the `steam_appid.txt` file in the build folder with the App ID of your game (use 480 for Spacewar)
6. Add game to steam as a non-steam game
   1. Disable SteamVR non-steam game theater mode in SteamVR settings
7. Run the game from steam
8. Have friend open game on their computer, also in steam
   <!-- Hardest step rip -->
   1. Potentially also acquire friend
9. Invite friend to game

## Tags

- `RollingBallOnly` - Only just stupid simple rolling ball game. No networking. No pickups
- `BasicMultiplayer` - Basic multiplayer game with lobby hosting through kcp
- `SteamMultiplayer` - Basic multiplayer game with lobby hosting through steam
- `v2.0.0` - Functional VR with SteamVR and Steam Multiplayer

## Resources Used

- [Rolling Ball Tutorial](https://learn.unity.com/project/roll-a-ball)
- [How to Make a Multiplayer Game with Mirror](https://www.youtube.com/watch?v=yD4cJx-bpVQ)
- [How to Make a Multiplayer Game with Mirror and Steam](https://www.youtube.com/watch?v=tFnNfq_EWWM)
- [How to Make a VR Multiplayer Game](https://www.youtube.com/watch?v=KHWuTBmT1oI)
- [Mirror Documentation](https://mirror-networking.gitbook.io/docs/)
- [Mirror VR Example](https://github.com/MirrorNetworking/ExamplesVR)

## Packages and Assets Used

- [Mirror](https://assetstore.unity.com/packages/tools/network/mirror-129321)
- [ParrelSync](https://github.com/VeriorPies/ParrelSync)
- [Debug Console](https://assetstore.unity.com/packages/tools/gui/in-game-debug-console-68068)
