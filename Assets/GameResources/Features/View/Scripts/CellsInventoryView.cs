namespace GameInventory.Features.View
{
    using GameInventory.Features.Model;
    using UnityEngine;

    /// <summary>
    /// Компонент отображения инвентаря, который хранит предметы в ячейках.
    /// </summary>
    [RequireComponent(typeof(RectTransform))]
    public sealed class CellsInventoryView : MonoBehaviour
    {
        [SerializeField]
        private CellsInventoryInfo _cellsInventoryInfo = null;
        [SerializeField]
        private CellSize _cellSize = null;

        private RectTransform _rectTransform = null;

        private void Start()
        {
            _rectTransform = gameObject.GetComponent<RectTransform>();
            _rectTransform.sizeDelta = new Vector2(
                _cellSize.Width * _cellsInventoryInfo.GetSize().x,
                _cellSize.Height * _cellsInventoryInfo.GetSize().y
                );
        }
    }
}
