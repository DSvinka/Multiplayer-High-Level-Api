using UnityEngine.Networking;

namespace Code
{
    public class NetworkManager: UnityEngine.Networking.NetworkManager
    {
        public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
        {
            base.OnServerAddPlayer(conn, playerControllerId);
        }
    }
}