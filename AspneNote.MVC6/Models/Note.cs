using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspneNote.MVC6.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호 
        /// </summary>
        [Key]
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목 
        /// </summary>
        [Required] // Not Null
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용 
        /// </summary>
        [Required] // Not Null
        public int NoteContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required] // Not Null
        public int UserNo { get; set; }

        [ForeignKey("USerNo")]
        public virtual User User { get; set; } //lazy loading 을 위해 virtual 을 넣어두자.



    }
}
