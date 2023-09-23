#region

using UnityEngine;

#endregion

namespace Data.Static.Trains
{
    [CreateAssetMenu(fileName = "RailwayCarriagesDataBase", menuName = "Data/Static/Trains/RailwayCarriagesDataBase")]
    public class RailwayCarriagesDatabase : ScriptableObject
    {
        [field: SerializeField] public RailwayCarriage[] RailwayCarriages { get; private set; }

        public RailwayCarriage GetRandomRailwayCarriage()
        {
            int randomIndex = Random.Range(0, RailwayCarriages.Length);
            return RailwayCarriages[randomIndex];
        }
    }
}
