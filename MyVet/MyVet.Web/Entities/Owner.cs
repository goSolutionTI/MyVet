using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]        
        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [MaxLength(12, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }



    	[MaxLength(12, ErrorMessage = "The {0} field can not have more than {1} characters.")]
    	[Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }



        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]        
        public string Address { get; set; }

        // SOLO DE LECTURA
        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameByDocument => $"{FirstName} {LastName}  -  {Document}";

        public ICollection<Pet> Pets { get; set; }
        public ICollection<Agenda> Agendas { get; set; }

    }
}
