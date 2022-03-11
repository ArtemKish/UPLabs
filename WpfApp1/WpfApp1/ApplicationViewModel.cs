using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Contact selectedContact;

        public ObservableCollection<Contact> Contacts { get; set; }

        public RelayCommand addCommand;

        public RelayCommand removeCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        Contact contact = new Contact();
                        Contacts.Insert(0, contact);
                        selectedContact = contact;
                    }));
            }
        }

        public RelayCommand RelayCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Contact phone = obj as Contact;
                        if (phone != null)
                        {
                            Contacts.Remove(phone);
                        }
                    },
                    (obj) => Contacts.Count > 0));
            }
        }

        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                OnPropertyChanged("SelectedContact");
            }
        }

        public ApplicationViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact {Name="Альберт", Surname="Макаров", Phone="89112934857"},
                new Contact {Name="Альберт", Surname="Макаров", Phone="89112934857"},
                new Contact {Name="Альберт", Surname="Макаров", Phone="89112934857"},
                new Contact {Name="Альберт", Surname="Макаров", Phone="89112934857"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
