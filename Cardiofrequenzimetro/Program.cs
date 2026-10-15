int eta, bpm, totBpm = 0, superamenti = 0, valoreRichiesta = 10, qtDati = 0;
const int COSTANTE_CALCOLO1 = 220;
float sogliaAnaerobica, mediaBpm;
const float COSTANTE_CALCOLO2 = 0.935f;
string richiesta = "si";
bool validita = false;

Console.WriteLine("Inserire l'eta' dell' atleta");
eta = Convert.ToInt16(Console.ReadLine());

sogliaAnaerobica = (COSTANTE_CALCOLO1 - eta) * COSTANTE_CALCOLO2;

do
{
    for (int i = 0; i < valoreRichiesta; i++)
    {
        do
        {
            Console.WriteLine("inserire un valore dei BPM");
            bpm = Convert.ToInt16(Console.ReadLine());

            if(bpm <= 0)
            {
                validita = false;
                Console.WriteLine("valore non valido, inserire un numero positivo");
            }
            else
            {
                validita = true;
            }
        } while (validita == false);

        if (sogliaAnaerobica < bpm)
        {
            superamenti++;
        }
        totBpm = totBpm + bpm;

        qtDati++;
    }

    Console.WriteLine("vuole continuare a inserire? (se si scrivere ''si'' altrimenti qualcos' altro)");
    richiesta = Console.ReadLine();

    if(richiesta == "si")
    {
        do
        {
            Console.WriteLine("quanti altri valori vuole inserire?");
            valoreRichiesta = Convert.ToInt16(Console.ReadLine());
            if (valoreRichiesta <= 0)
            {
                Console.WriteLine("valore non valido, reinserire");
            }
        } while (valoreRichiesta <= 0);
        

    }

} while (richiesta == "si");

mediaBpm = totBpm / qtDati;

Console.WriteLine("la media dei bpm e' "+ mediaBpm+ "; la Soglia anaerobica e'" + sogliaAnaerobica +" ed e' stata superata " + superamenti+ " volte");