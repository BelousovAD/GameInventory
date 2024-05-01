namespace GameInventory.Features.Model
{
    using UnityEngine;

    /// <summary>
    /// Информация о предмете, который хранится в ячейках.
    /// </summary>
    [CreateAssetMenu(fileName = "ItemInCellsInfo", menuName = "GameInventory/Features/Model/ItemInCellsInfo")]
    public class ItemInCellsInfo : BaseItemInfo
    {
        [SerializeField]
        private Sprite _sprite;

        /// <summary>
        /// Возвращает изображение предмета.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Sprite GetSprite() => _sprite;

        [SerializeField]
        [Min(0)]
        private Vector2Int _sizeInInventory = Vector2Int.zero;

        /// <summary>
        /// Возвращает размер предмета в инвентаре.
        /// </summary>
        /// <returns>Размер в инвентаре.</returns>
        public Vector2Int GetSizeInInventory() => _sizeInInventory;
    }
}
