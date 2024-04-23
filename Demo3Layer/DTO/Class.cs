using System.Data;

namespace Demo3Layer.DTO
{
    public class Class
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the class.
        /// </summary>
        public string? ClassName { get; set; }
        public string? ImgUrl { get; set; }

        public Class(int? id, string className, string? imgUrl)
        {
            Id = id;
            ClassName = className;
            ImgUrl = imgUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Class"/> class.
        /// </summary>
        /// <param name="row">The row.</param>
        public Class(DataRow row)
        {
            Id = (int)row["Id"];
            ClassName = row["ClassName"].ToString();
            ImgUrl = row["ImgUrl"].ToString();
        }
    }
}
