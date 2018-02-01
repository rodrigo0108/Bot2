using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Office365Prueba1.Utils
{
    public class Constantes
    {
        private static readonly Lazy<Constantes> instance = new Lazy<Constantes>(() => new Constantes());
        private Constantes()
        {
        }
        public static Constantes Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public String proponer()
        {

            Random rnd = new Random();
            string[] respuestas = {
                        "¡Mira! \U0001F604, tengo esto: ",
                        "tengo esto: \U0001F603 ",
                        "encontré la siguiente respuesta \U0001F601",
                        "pude encontrar lo siguiente \U0001F600"
                    };

            int mIndex = rnd.Next(0, respuestas.Length);
            return respuestas[mIndex];
        }

        public String despedir()
        {
            Random rnd = new Random();

            string[] despedidas = {
                        "Fue un gusto poder haberte ayudado, cuenta conmigo la próxima vez, nos vemos! \U0001F917",
                        "¡Hasta Pronto! \U0001F603",
                        "¡Nos vemos pronto! \U0001F917",
                        "¡Que tengas un buen día, gracias por contar conmigo! \U0001F603"
                    };
            int mIndex = rnd.Next(0, despedidas.Length);
            return despedidas[mIndex];
        }

        

    }
}