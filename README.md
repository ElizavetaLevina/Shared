# Shared

Shared — общая библиотека с DTO и Enum для RabbitMQ-взаимодействия между BackendService и ModerationService.

> **Связанные репозитории:**
> - [BackendService](https://github.com/ElizavetaLevina/BackendService) — основной API для работы с постами
> - [ModerationService](https://github.com/ElizavetaLevina/ModerationService) — сервис проверки контента

## Содержание

### DTO
| Класс | Назначение |
|-------|-------------|
| `PostSubmittedForModeration` | Отправка поста на модерацию |
| `PostModeratedEvent` | Результат проверки |

### Enum
| Enum | Назначение |
|------|-------------|
| `ModerationStatus` | Статус модерации |

## Используемые технологии

C# / .NET 8