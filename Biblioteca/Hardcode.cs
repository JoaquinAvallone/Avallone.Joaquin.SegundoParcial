using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Hardcode
    {
        public static List<Jugador> HardcodeJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();

            Jugador jugador1 = new Jugador("Robert");
            Jugador jugador2 = new Jugador("MaestroDeDados");
            Jugador jugador3 = new Jugador("ElGeneCrack");
            Jugador jugador4 = new Jugador("FullMaster");
            Jugador jugador5 = new Jugador("EscaleraServida");
            Jugador jugador6 = new Jugador("TiraDados");
            Jugador jugador7 = new Jugador("Pepe");

            jugadores.Add(jugador1);
            jugadores.Add(jugador2);
            jugadores.Add(jugador3);
            jugadores.Add(jugador4);
            jugadores.Add(jugador5);
            jugadores.Add(jugador6);
            jugadores.Add(jugador7);

            return jugadores;
        }
    }
}
