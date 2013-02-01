using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestComposite
{
    public abstract class Composant
    {
        public string nom { get; private set; }

        public Composant(string nom)
        {
            this.nom = nom;
        }

        public abstract void Ajouter(Composant c);
        public abstract void Retirer(Composant c);
        public abstract void Afficher(int profondeur);
    }
}
