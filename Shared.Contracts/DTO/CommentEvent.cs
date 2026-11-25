namespace Shared.Contracts.DTO;

public class CommentEvent
{
    /// <summary>
    /// Идентификатор сообщения
    /// </summary>
    public Guid MessageId { get; set; }

    /// <summary>
    /// Идентификатор комментария
    /// </summary>
    public int CommentId { get; set; }

    /// <summary>
    /// Текст комментария
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// Автор комментария
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор поста
    /// </summary>
    public int PostId { get; set; }

    /// <summary>
    /// Идентификатор родительского комментария
    /// </summary>
    public int? ParentCommentId { get; set; }

    /// <summary>
    /// Дата создания комментария
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Дата последнего обновления
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Удалён ли комментарий
    /// </summary>
    public bool IsDeleted { get; set; }
}