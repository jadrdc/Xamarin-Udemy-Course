using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Models
{ [Table("Contacts")]
   public class Contact : INotifyPropertyChanged
    {
        private string _name;



        [MaxLength(255)]
        public string Name
        {
            get { return _name; }



            set
            {
                if (_name == value)
                    return;



                _name = value;



                OnPropertyChanged();
            }
        }         private string _lastname;
        public string LastName
        {
            get { return _lastname; }



            set
            {
                if (_lastname == value)
                    return;



                _lastname = value;



                OnPropertyChanged();
            }
        }

        [MaxLength(255)]
        [PrimaryKey]
        public string Telephone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        public Boolean Blocked { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]
                                                               string  propertyName    =   null)
        {
            PropertyChanged?.Invoke(this, new
                            PropertyChangedEventArgs(propertyName));
        }

    }
}
