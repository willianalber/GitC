using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG1.Classes
{
    class Cantina
    {
        List<Lanches> Cardapio;

        public Cantina()
        {
            Cardapio = new List<Lanches>();
            //Lanches lanche = new Lanches("Caxinha",5);
            Cardapio.Add(new Lanches("Coxinha", 5));
            Cardapio.Add(new Lanches("Pastel", 10));
            Cardapio.Add(new Lanches("Mini pizza", 25));
            Cardapio.Add(new Lanches("Coca Cola", 8));
            Cardapio.Add(new Lanches("X Salada", 5));
            Cardapio.Add(new Lanches("Bolinho de Carne", 10));
            Cardapio.Add(new Lanches("X Bacon", 25));
            Cardapio.Add(new Lanches("X Frango", 8));
            Cardapio.Add(new Lanches("X Bacon", 25));
            Cardapio.Add(new Lanches("X Frango", 8));
        }

        public List<Lanches> cardapio
        {
            get
            {
                return Cardapio;
            }

            set
            {
                Cardapio = value;
            }
        }
    }

}
