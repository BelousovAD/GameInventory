namespace GameInventory.Feature.Model
{
    using UnityEngine;

    /// <summary>
    /// Информация о предмете.
    /// </summary>
    [CreateAssetMenu]
    public class ItemInfo : ScriptableObject
    {
        [SerializeField]
        private string _itemId = string.Empty;

        /// <summary>
        /// Возвращает идентификатор предмета.
        /// </summary>
        /// <returns>Идентификатор.</returns>
        public string GetItemId() => _itemId;

        [SerializeField]
        [Range(0f, 1f)]
        private float _itemState = 1f;

        /// <summary>
        /// Возвращает состояние предмета.
        /// </summary>
        /// <returns>Состояние.</returns>
        public float GetItemState() => _itemState;

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
