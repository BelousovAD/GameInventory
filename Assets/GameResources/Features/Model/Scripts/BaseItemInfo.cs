namespace GameInventory.Features.Model
{
    using UnityEngine;

    /// <summary>
    /// Базовый класс информации о предмете.
    /// </summary>
    [CreateAssetMenu(fileName = "BaseItemInfo", menuName = "GameInventory/Features/Model")]
    public class BaseItemInfo : ScriptableObject
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
    }
}
