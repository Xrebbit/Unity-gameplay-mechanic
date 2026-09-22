# Save / Load System

Простое сохранение и загрузка данных в JSON через `Application.persistentDataPath` — независимо от платформы.

## Как использовать

```csharp
SaveManager.Save(playerData);
var data = SaveManager.Load<PlayerData>();
```

`T` — любой сериализуемый класс (`[System.Serializable]`).

## Паттерны

- Generic-методы для работы с произвольным типом данных
- Статический класс-утилита (без наследования от MonoBehaviour)
- JsonUtility для сериализации
