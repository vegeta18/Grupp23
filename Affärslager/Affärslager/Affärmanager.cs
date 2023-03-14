using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellager;
using Datalager;
using System.Runtime.CompilerServices;

namespace Affärslager
{
    public class Affärmanager
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new BibliotekContext());


        #region Expidit

        public List<Expedit> GetExpediter() //hämtar alla expiditer i lista, för att man senare ska kunna välja en av de
        {
            return unitOfWork.Expediter.GetAll().ToList();
        }

        public Expedit GetExpedit(int AnställningsID) //Hämtar specifik expidit
        {
            return unitOfWork.Expiditer.Get(AnställningsID);
        }


        #endregion

        #region Medlem
        public Medlem GetMedlem(int MedlemsID) //Hämtar specifik medlem
        {
            return unitOfWork.Medlemmar.Get(MedlemsID);
        }

        public List<Medlem> GetMedlemmar()
        {
            return unitOfWork.Medlemmar.GetAll().ToList();
        }

        #endregion

        #region Bok
        public List<Bok> GetBöcker()
        {
            return unitOfWork.Böcker.GetAll().ToList();
        }

        public Bok GetBok(string ISBNnummer)
        {
            return unitOfWork.Böcker.Get(ISBNnummer);
        }

        public void RemoveBok(string ISBNnummer)
        {
            var removeBok = unitOfWork.Böcker.Get(ISBNnummer);
            unitOfWork.Böcker.Remove(removeBok); //Dubbelkolla varför den snear
            unitOfWork.Save();
        }

        //Add funktion


        #endregion
    }
}
