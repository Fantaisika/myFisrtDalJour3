using System.Collections.Generic;
using System.Linq;

namespace myFirstDAL.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;

        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public List<Sejour> ObtientTousLesSejours()
        {
            return _bddContext.Sejours.ToList();
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }

        public int CreerSejour(string lieu, string telephone)
        {
            Sejour sejour = new Sejour() { Lieu = lieu, Telephone = telephone };
            _bddContext.Sejours.Add(sejour);

            _bddContext.SaveChanges();

            return sejour.Id;
        }

        public void UpdateSejour(int id, string newLieu, string newTelephone)
        {
            Sejour sejour = _bddContext.Sejours.Find(id);
            if (sejour != null)
            {
                sejour.Lieu = newLieu;
                sejour.Telephone = newTelephone;

                _bddContext.SaveChanges();
            }
        }

        public void DeleteSejour(int id)
        {
            Sejour sejour = _bddContext.Sejours.Find(id);
            if (sejour != null)
            {
                _bddContext.Sejours.Remove(sejour);
                _bddContext.SaveChanges();
            }
        }

        public Sejour GetSejour(int id)
        {
            return _bddContext.Sejours.Find(id);
        }

        public Sejour GetSejourt(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
