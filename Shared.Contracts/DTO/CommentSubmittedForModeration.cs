namespace Shared.Contracts.DTO
{
    public class CommentSubmittedForModeration
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Content { get; set; }
    }
}
