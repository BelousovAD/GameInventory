namespace GameInventory.Features.Model
{
    using System.IO;
    using UnityEngine;

    /// <summary>
    /// Скрипт сохранения/загрузки объектов в/из JSON-файл.
    /// </summary>
    public class SaverToJSON
    {
        private string _pathToSave = string.Empty;

        /// <summary>
        /// Создаёт объект скрипта сохранения/загрузки.
        /// </summary>
        public SaverToJSON() { }

        /// <summary>
        /// Устанавливает путь для сохранения файлов.
        /// </summary>
        /// <param name="pathToSave">Путь для сохранения.</param>
        public void Initialize(string pathToSave) => _pathToSave = pathToSave;

        /// <summary>
        /// Сохраняет объект в JSON-файл.
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <param name="fileName">Имя файла.</param>
        public void Save(Object obj, string fileName)
        {
            string jsonString = JsonUtility.ToJson(obj);
            string filePath = Path.Combine(_pathToSave, fileName + ".json");
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Загружает объект из JSON-файла.
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <param name="fileName">Имя файла.</param>
        public void Load(out Object obj, string fileName)
        {
            string filePath = Path.Combine(_pathToSave, fileName + ".json");
            string jsonString = File.ReadAllText(filePath);
            obj = JsonUtility.FromJson<Object>(jsonString);
        }
    }
}
