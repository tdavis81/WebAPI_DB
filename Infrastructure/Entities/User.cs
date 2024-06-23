using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/*Sample Entity class, this class will mock whatever database tables you have */

namespace WebAPI_DB.Infrastructure.Entities
{
    /*DB Table name goes here*/
    [Table("User")]
    public class User
    {
        /*Primary Key goes here*/
        [Key]
        public Guid UserGuid { get; set; }

        public string? UserLogon { get; set; }
    }
}
