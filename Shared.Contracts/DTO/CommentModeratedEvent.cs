using Shared.Contracts.Enum;

namespace Shared.Contracts.DTO
{
    public class CommentModeratedEvent
    {
        /// <summary>
        /// Уникальный идентификатор сообщения
        /// </summary>
        public Guid MessageId { get; set; }
        
        /// <summary>
        /// Идентификатор комментария на модерации
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// Статус модерации
        /// </summary>
        public StatusModerationEnum Status { get; set; }

        /// <summary>
        /// Причина отклонения
        /// </summary>
        public string? RejectionReason { get; set; } = null;

        /// <summary>
        /// Дата завершения модерации
        /// </summary>
        public DateTime ModeratedAt { get; set; } = DateTime.UtcNow;
    }
}