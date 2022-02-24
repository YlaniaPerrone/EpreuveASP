using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entity
{
    public class Membre
    {
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int idPays { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // public Pays pays { get; set; }

        // public Membre(int id_Membre, string nom, string prenom, string email, string telephone, string login, string password, Pays pays)
        // {
        //     idMembre = id_Membre;
        //     Nom = nom;
        //     Prenom = prenom;
        //     Email = email;
        //     Telephone = telephone;
        //     Login = login;
        //     Password = password;
        //     //Pays = pays;
        //     //if (pays == null) throw new ArgumentNullException(nameof(idPays));
        //     //idPays = pays.idPays;
        // }
        //
        // public Membre(int id_Membre, string nom, string prenom, string email, int id_Pays, string telephone, string login, string password)
        // {
        //     idMembre = id_Membre;
        //     Nom = nom;
        //     Prenom = prenom;
        //     Email = email;
        //     idPays = id_Pays;
        //     Telephone = telephone;
        //     Login = login;
        //     Password = password;
        // }

      


    }
}
