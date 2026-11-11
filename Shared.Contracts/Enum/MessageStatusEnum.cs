namespace Shared.Contracts.Enum
{
    /// <summary>
    /// Статус сообщения
    /// </summary>
    public enum MessageStatusEnum
    {
        /// <summary>
        /// Сообщение в ожидании отправки
        /// </summary>
        Pending,

        /// <summary>
        /// Сообщение отправлено
        /// </summary>
        Sent,

        /// <summary>
        /// Ошибка при отправке
        /// </summary>
        Failed
    }
}