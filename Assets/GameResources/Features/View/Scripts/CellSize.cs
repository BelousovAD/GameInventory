namespace GameInventory.Features.View
{
    using UnityEngine;

    /// <summary>
    /// Размер ячейки.
    /// </summary>
    [CreateAssetMenu(fileName = "CellSize", menuName = "GameInventory/Features/View/CellSize")]
    public class CellSize : ScriptableObject
    {
        /// <summary>
        /// Ширина ячейки.
        /// </summary>
        [Min(0f)]
        public float Width = 0f;

        /// <summary>
        /// Высота ячейки.
        /// </summary>
        [Min(0f)]
        public float Height = 0f;
    }
}
