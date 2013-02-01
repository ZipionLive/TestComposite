using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestComposite
{
    public class Composite : Composant
    {
        private readonly List<Composant> Composants;

        public Composite(string nom) : base(nom)
        {
            this.Composants = new List<Composant>();
        }

        public Composite(string nom, params Composant[] Composants)
            : this(nom)
        {
            this.Composants.AddRange(Composants);
        }

        public override void Ajouter(Composant c)
        {
            this.Composants.Add(c);
        }

        public override void Retirer(Composant c)
        {
            this.Composants.Remove(c);
        }

        public override void Afficher(int profondeur)
        {
            Console.WriteLine("{0}{1}", new string('-', profondeur), nom);

            foreach (Composant c in Composants)
            {
                c.Afficher(profondeur + 2);
            }
        }
    }
}
