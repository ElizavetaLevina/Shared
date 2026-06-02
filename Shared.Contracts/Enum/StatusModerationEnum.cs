namespace Shared.Contracts.Enum
{
    /// <summary>
    /// Статус модерации для поста
    /// </summary>
    public enum StatusModerationEnum
    {
        /// <summary>
        /// В ожидании отправки
        /// </summary>
        Pending,

        /// <summary>
        /// Отправлено на модерацию
        /// </summary>
        SentForModeration,

        /// <summary>
        /// Одобрено
        /// </summary>
        Approved,

        /// <summary>
        /// Отклонено
        /// </summary>
        Rejected
    }
}
