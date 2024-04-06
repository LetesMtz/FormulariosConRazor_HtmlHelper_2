using System.ComponentModel.DataAnnotations;

namespace FormulariosConRazor_HtmlHelper_2.Models
{
    public class equipos
    {
        [Key]
        public int id_equipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int marca_id { get; set; }
    }
}
