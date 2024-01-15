using System;
using System.Collections.Generic;

namespace myFirstDAL.Models
{
    public interface IDal : IDisposable // une interface qui hérite d'une autre interface IDisposable permet de travailler proprement , netoyer la memoire
    {
        void DeleteCreateDatabase();
        List<Sejour> ObtientTousLesSejours();
        int CreerSejour(string lieu, string telephone);
        public Sejour GetSejourt(int Id);
        public void UpdateSejour(int Id, string lieu, string telephone);

        public void DeleteSejour(int id);
    }
}
